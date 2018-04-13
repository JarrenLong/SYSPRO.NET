using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSPRO.NET.BusinessObjects.SORTOI
{
    public partial class Parameters
    {
        public Parameters(int unused)
            : this()
        {
            this.InBoxMsgReqd = InBoxMsgReqd.Item;
            this.InBoxMsgReqdSpecified = true;
            this.Process = Process.Import;
            this.ProcessSpecified = true;
            this.CustomerToUse = "";
            this.WarehouseListToUse = "";
            this.TypeOfOrder = TypeOfOrder.ORD;
            this.TypeOfOrderSpecified = true;
            this.OrderStatus = OrderStatus.Item1;
            this.OrderStatusSpecified = true;
            this.MinimumDaysToShip = "";
            this.AllowNonStockItems = AllowNonStockItems.Y;
            this.AllowNonStockItemsSpecified = true;
            this.AcceptOrdersIfNoCredit = AcceptOrdersIfNoCredit.Y;
            this.AcceptOrdersIfNoCreditSpecified = true;
            this.AcceptEarlierShipDate = AcceptEarlierShipDate.N;
            this.AcceptEarlierShipDateSpecified = true;
            this.OperatorToInform = "";
            this.CreditFailMessage = "";
            this.ValidProductClassList = "";
            this.ShipFromDefaultBin = ShipFromDefaultBin.Item;
            this.ShipFromDefaultBinSpecified = true;
            this.AllowInvoiceInformationEntry = AllowInvoiceInformationEntry.Item;
            this.AllowInvoiceInformationEntrySpecified = true;
            this.AlwaysUsePriceEntered = AlwaysUsePriceEntered.Item;
            this.AlwaysUsePriceEnteredSpecified = true;
            this.AllowZeroPrice = AllowZeroPrice.Item;
            this.AllowZeroPriceSpecified = true;
            this.AllowChangeToZeroPrice = AllowChangeToZeroPrice.Item;
            this.AllowChangeToZeroPriceSpecified = true;
            this.UseStockDescSupplied = UseStockDescSupplied.Item;
            this.UseStockDescSuppliedSpecified = true;
            this.ValidateShippingInstrs = ValidateShippingInstrs.Item;
            this.ValidateShippingInstrsSpecified = true;
            this.AllocationAction = AllocationAction.Item;
            this.AllocationActionSpecified = true;
            this.AddAttachedServiceCharges = AddAttachedServiceCharges.Item;
            this.AddAttachedServiceChargesSpecified = true;
            this.StatusInProcess = StatusInProcess.Item;
            this.StatusInProcessSpecified = true;
            this.StatusInProcessResponse = StatusInProcessResponse.Item;
            this.StatusInProcessResponseSpecified = true;
            this.AllowBackOrderForPartialHold = AllowBackOrderForPartialHold.Item;
            this.AllowBackOrderForPartialHoldSpecified = true;
            this.AllowBackOrderForSuperseded = AllowBackOrderForSuperseded.Item;
            this.AllowBackOrderForSupersededSpecified = true;
            this.OverrideCustomerBackOrder = OverrideCustomerBackOrder.Item;
            this.OverrideCustomerBackOrderSpecified = true;
            this.UseMasterAccountForCustomerPartNo = UseMasterAccountForCustomerPartNo.Item;
            this.UseMasterAccountForCustomerPartNoSpecified = true;
            this.ApplyLeadTimeCalculation = ApplyLeadTimeCalculation.Item;
            this.ApplyLeadTimeCalculationSpecified = true;
            this.ReserveStock = ReserveStock.Item;
            this.ReserveStockSpecified = true;
            this.ReserveStockRequestAllocs = ReserveStockRequestAllocs.Item;
            this.ReserveStockRequestAllocsSpecified = true;
            this.AllowDuplicateOrderNumbers = AllowDuplicateOrderNumbers.Y;
            this.AllowDuplicateOrderNumbersSpecified = true;
            this.CheckForCustomerPoNumbers = CheckForCustomerPoNumbers.Item;
            this.CheckForCustomerPoNumbersSpecified = true;
            this.AddStockSalesOrderText = AddStockSalesOrderText.Item;
            this.AddStockSalesOrderTextSpecified = true;
            this.AddDangerousGoodsText = AddDangerousGoodsText.Item;
            this.AddDangerousGoodsTextSpecified = true;
            this.IgnoreWarnings = IgnoreWarnings.Item;
            this.IgnoreWarningsSpecified = true;
            this.WarnIfCustomerOnHold = WarnIfCustomerOnHold.Item;
            this.WarnIfCustomerOnHoldSpecified = true;
            this.AcceptKitOptional = AcceptKitOptional.Item;
            this.AcceptKitOptionalSpecified = true;
            this.ApplyParentDiscountToComponents = ApplyParentDiscountToComponents.N;
            this.ApplyParentDiscountToComponentsSpecified = true;
            this.AllowManualOrderNumberToBeUsed = AllowManualOrderNumberToBeUsed.Item;
            this.AllowManualOrderNumberToBeUsedSpecified = true;
            this.AllowBackOrderForNegativeMerchLine = AllowBackOrderForNegativeMerchLine.Item;
            this.AllowBackOrderForNegativeMerchLineSpecified = true;
        }
    }
}
