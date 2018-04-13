using SYSPROWCFServicesClientLibrary40;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

//#if SYSPRO_API70
//namespace SYSPRO7.NET
//#else
namespace SYSPRO.NET
//#endif
{
  /// <summary>
  /// Provides a convenience wrapper for integrating with SYSPRO v6.1 SP1
  /// </summary>
  /// <example>
  /// <code>
  /// SYSPROHelper.ServiceHost = "sysproappserver:98"
  /// SYSPROHelper.UserName = "ADMIN"
  /// SYSPROHelper.Password = "****"
  /// SYSPROHelper.CompanyID = "YourCompanyNumber"
  /// SYSPROHelper.CompanyPass = "****"
  ///  
  /// Dim inst As SYSPROHelper = SYSPROHelper.Instance
  /// Dim xmlOut As String = inst.Browse("ARSTIN", "XmlParams", "XmlIn")
  /// ' Process response ...
  /// Dim xmlOut2 As String = inst.Post("SORTOI", "XmlParams", "XmlIn")
  /// ' Process response ...
  /// </code></example>
  /// <remarks></remarks>
  public class SYSPROHelper : IDisposable
  {
#if SYSPRO_API61
    public const string API_Version = "6.1";
#elif SYSPRO_API70
    public const string API_Version = "7.0";
#else
    public const string API_Version = "?.?";
#endif

    #region SYSPROHelper Initialization
    /// <summary>
    /// Default constructor, performs SYSPRO setup and Logon
    /// </summary>
    public SYSPROHelper()
    {
      //Instantiate the Primitive Client using the BaseAddress of the service and the binding to use
      ToDebugLog("Initializing SYSPROHelper v{0}...", API_Version);
      _Client = new SYSPROWCFServicesPrimitiveClient(string.Format("net.tcp://{0}/SYSPROWCFService", ServiceHost), SYSPROWCFBinding.NetTcp);

      if (!Logon(UserName, Password, CompanyID, CompanyPass))
      {
        ToLog("SYSPRO Logon failed for user {0}!", UserName);
        throw new Exception(string.Format("SYSPRO Logon failed for user {0}!", UserName));
      }

      ToDebugLog("SYSPRO Logon successful!");
    }

    /// <summary>
    /// The SYSPRO WCF client object
    /// </summary>
    private SYSPROWCFServicesPrimitiveClient _Client = null;
    /// <summary>
    /// Tracks the current user logon session ID (GUID)
    /// </summary>
    private string _UserID = "";
    public static string ServiceHost { get; set; }
    public static string UserName { get; set; }
    public static string Password { get; set; }
    public static string CompanyID { get; set; }
    // SYSPRComNo
    public static string CompanyPass { get; set; }
    public delegate void LogDelegate(string msg, params object[] args);
    public static LogDelegate LogFn = null;

    private static void ToLog(string msg, params object[] args)
    {
      LogFn?.Invoke(msg, args);
    }
    private static void ToLogErrorsOnly(string msg, params object[] args)
    {
      if (string.Format(msg, args).ToLower().Contains("err"))
        ToLog(msg, args);
    }
    private static void ToDebugLog(string msg, params object[] args)
    {
#if DEBUG
      ToLog(msg, args);
#endif
    }
    #endregion

    #region Public methods
    #region SYSPRO Setup
    /// <summary>
    /// Used to add one or more items to the database with a single call
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlParamString"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Add(string BusinessObject, string XmlParamString, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_SetupAdd: UserId: {0}, BusinessObject: {1}, Params: {2}, Object: {3}", _UserID, BusinessObject, XmlParamString, XmlObjectString);
      string ret = _Client.SetupAdd(_UserID, BusinessObject, XmlParamString, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paramObj"></param>
    /// <param name="valueObj"></param>
    /// <returns></returns>
    public T Add<T>(object paramObj, object valueObj)
    {
      return FromXml<T>(Add(GetBOType(paramObj), ToXml(paramObj), ToXml(valueObj)));
    }

    /// <summary>
    /// Used to modify one or more items in the database with a single call
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlParamString"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Update(string BusinessObject, string XmlParamString, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_SetupUpdate: UserId: {0}, BusinessObject: {1}, Params: {2}, Object: {3}", _UserID, BusinessObject, XmlParamString, XmlObjectString);
      string ret = _Client.SetupUpdate(_UserID, BusinessObject, XmlParamString, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paramObj"></param>
    /// <param name="valueObj"></param>
    /// <returns></returns>
    public T Update<T>(object paramObj, object valueObj)
    {
      return FromXml<T>(Update(GetBOType(paramObj), ToXml(paramObj), ToXml(valueObj)));
    }

    /// <summary>
    /// Used to delete one or more items in the database with a single call
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlParamString"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Delete(string BusinessObject, string XmlParamString, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_SetupDelete: UserId: {0}, BusinessObject: {1}, Params: {2}, Object: {3}", _UserID, BusinessObject, XmlParamString, XmlObjectString);
      string ret = _Client.SetupDelete(_UserID, BusinessObject, XmlParamString, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paramObj"></param>
    /// <param name="valueObj"></param>
    /// <returns></returns>
    public T Delete<T>(object paramObj, object valueObj)
    {
      return FromXml<T>(Delete(GetBOType(paramObj), ToXml(paramObj), ToXml(valueObj)));
    }
    #endregion

    #region SYSPRO Transaction
    /// <summary>
    /// Used to retrieve information helpful during the post
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlParamString"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Post(string BusinessObject, string XmlParamString, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_TransactionPost: UserId: {0}, BusinessObject: {1}, Params: {2}, Object: {3}", _UserID, BusinessObject, XmlParamString, XmlObjectString);
      string ret = _Client.TransactionPost(_UserID, BusinessObject, XmlParamString, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="paramObj"></param>
    /// <param name="valueObj"></param>
    /// <returns></returns>
    public T Post<T>(object paramObj, object valueObj)
    {
      return FromXml<T>(Post(GetBOType(paramObj), ToXml(paramObj), ToXml(valueObj)));
    }

    /// <summary>
    /// Used to post transactions
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Build(string BusinessObject, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_TransactionBuild: UserId: {0}, BusinessObject: {1}, Object: {2}", _UserID, BusinessObject, XmlObjectString);
      string ret = _Client.TransactionBuild(_UserID, BusinessObject, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public T Build<T>(object obj)
    {
      return FromXml<T>(Build(GetBOType(obj), ToXml(obj)));
    }
    #endregion

    #region SYSPRO Query
    /// <summary>
    /// Used to generically browse columns from a table
    /// </summary>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Browse(string XmlObjectString)
    {
      ToDebugLog("SYSPRO_QueryBrowse: UserId: {0}, Object: {1}", _UserID, XmlObjectString);
      string ret = _Client.QueryBrowse(_UserID, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public T Browse<T>(object obj)
    {
      return FromXml<T>(Browse(ToXml(obj)));
    }

    /// <summary>
    /// Used to generically return all rows from a specified column in a table
    /// </summary>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Fetch(string XmlObjectString)
    {
      ToDebugLog("SYSPRO_QueryFetch: UserId: {0}, Object: {1}", _UserID, XmlObjectString);
      string ret = _Client.QueryFetch(_UserID, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public T Fetch<T>(object obj)
    {
      return FromXml<T>(Fetch(ToXml(obj)));
    }

    /// <summary>
    /// Used to access query-type business objects
    /// </summary>
    /// <param name="BusinessObject"></param>
    /// <param name="XmlObjectString"></param>
    /// <returns></returns>
    public string Query(string BusinessObject, string XmlObjectString)
    {
      ToDebugLog("SYSPRO_QueryQuery: UserId: {0}, BusinessObject: {1}, Object: {3}", _UserID, BusinessObject, XmlObjectString);
      string ret = _Client.QueryQuery(_UserID, BusinessObject, XmlObjectString);
      ToLogErrorsOnly("Result: {0}", ret);
      return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public T Query<T>(object obj)
    {
      return FromXml<T>(Query(GetBOType(obj), ToXml(obj)));
    }
    #endregion

    #region XML Serialization
    /// <summary>
    /// Serialize an object to its xml string equivalent
    /// </summary>
    /// <param name="obj">The object to serialize</param>
    /// <returns>An XML string representing the object</returns>
    public string ToXml(object obj)
    {
      ToDebugLog("Converting {0} type object to XML", obj.GetType());

      XmlSerializer x = new XmlSerializer(obj.GetType());
      using (Utf8StringWriter sw = new Utf8StringWriter())
      {
        using (XmlWriter xw = XmlWriter.Create(sw))
        {
          XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
          xns.Add("noNamespaceSchemaLocation", GetBOType(obj) + ".XSD");
          xns.Add("xsd", "http://www.w3.org/2001/XMLSchema-instance");
          x.Serialize(xw, obj, xns);
          return sw.ToString().Replace("xmlns:noNamespaceSchemaLocation", "xsd:noNamespaceSchemaLocation").Replace("encoding=\"utf-8\"", "encoding=\"WINDOWS-1252\"");
        }
      }
    }

    /// <summary>
    /// Deserialize an object of a specific type from an XML string
    /// </summary>
    /// <typeparam name="T">The type of object to deserialize</typeparam>
    /// <param name="xml">The XML string to deserialize</param>
    /// <returns>The deserialized object</returns>
    public T FromXml<T>(string xml)
    {
      ToDebugLog("Converting XML to {0} type object", typeof(T));

      XmlSerializer x = new XmlSerializer(typeof(T));
      using (StringReader sr = new StringReader(xml))
        return (T)x.Deserialize(sr);
    }
    #endregion
    #endregion

    #region Private methods
    /// <summary>
    /// Logs on a new SYSPRO user, called when the instance is first created
    /// </summary>
    /// <param name="operatorName">The operator's user name</param>
    /// <param name="operatorPassword">The operator's password</param>
    /// <param name="companyID">The company ID</param>
    /// <param name="companyPassword">The company password</param>
    /// <returns></returns>
    private bool Logon(string operatorName, string operatorPassword, string companyID, string companyPassword)
    {
      ToLog("Connecting to company {0} on server {1} using user {2}...", companyID, ServiceHost, operatorName);
      _UserID = _Client.Logon(operatorName, operatorPassword, companyID, companyPassword);
      return !String.IsNullOrEmpty(_UserID);
    }

    /// <summary>
    /// Logs off the current SYSPRO user
    /// </summary>
    private void Logoff()
    {
      if (!String.IsNullOrEmpty(_UserID))
      {
        ToDebugLog("Disconnecting from SYSPRO ...");
        _Client.Logoff(_UserID);
        _UserID = null;
      }
    }

    /// <summary>
    /// Returns the type of the SYSPRO business object (schema name)
    /// </summary>
    /// <param name="obj">The business object to get the type for</param>
    /// <returns>The type of the SYSPRO business object (schema name)</returns>
    private string GetBOType(object obj)
    {
      return obj.GetType().Namespace.Replace("SYSPRO.NET.BusinessObjects.", "");
    }

    #region IDisposable Implementation
    private bool disposedValue;
    /// <summary>
    /// Disposes of this object
    /// </summary>
    /// <param name="disposing">True if this object is disposing</param>
    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposedValue)
      {
        if (disposing)
        {
          Logoff();
          ToDebugLog("Cleaning up SYSPROHelper...");
          _Client = null;
          _UserID = null;
        }
      }

      this.disposedValue = true;
    }

    /// <summary>
    /// Disposes of this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
    #endregion
    #endregion

    /// <summary>
    /// A small wrapper around StringWriter to set the default string encoding to UTF-8
    /// </summary>
    internal class Utf8StringWriter : StringWriter
    {
      public override Encoding Encoding
      {
        get { return Encoding.UTF8; }
      }
    }
  }
}
