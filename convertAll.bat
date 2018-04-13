@echo off

for %%f in (Schemas7\*.xsd) do (
	xsd Schemas7\%%~nf.xsd /t:lib /l:cs /c /n:SYSPRO.NET.BusinessObjects.%%~nf /o:BusinessObjects7
)
