/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:26.72
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.homeback', false, function () {
   this.ServerClass =  "wwpbaseobjects.homeback" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
   };
   this.e137v2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e147v2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,18,19,20,23,24,25,26,27];
   this.GXLastCtrlId =27;
   this.VSITUATIONIMAGEContainer = gx.uc.getNew(this, 17, 0, "sgHighChartsBasic", "VSITUATIONIMAGEContainer", "Vsituationimage", "VSITUATIONIMAGE");
   var VSITUATIONIMAGEContainer = this.VSITUATIONIMAGEContainer;
   VSITUATIONIMAGEContainer.setProp("Class", "Class", "", "char");
   VSITUATIONIMAGEContainer.setProp("Enabled", "Enabled", true, "boolean");
   VSITUATIONIMAGEContainer.setProp("Width", "Width", "600", "str");
   VSITUATIONIMAGEContainer.setProp("Height", "Height", "450", "str");
   VSITUATIONIMAGEContainer.addV2CFunction('AV42tSituation', "vTSITUATION", 'SetOptionJson');
   VSITUATIONIMAGEContainer.addC2VFunction(function(UC) { UC.ParentObject.AV42tSituation=UC.GetOptionJson();gx.fn.setControlValue("vTSITUATION",UC.ParentObject.AV42tSituation); });
   VSITUATIONIMAGEContainer.setProp("SwitchType", "Switchtype", "none", "str");
   VSITUATIONIMAGEContainer.setProp("Visible", "Visible", true, "bool");
   VSITUATIONIMAGEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(VSITUATIONIMAGEContainer);
   this.DVPANEL_UNNAMEDTABLE1Container = gx.uc.getNew(this, 10, 0, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE1Container", "Dvpanel_unnamedtable1", "DVPANEL_UNNAMEDTABLE1");
   var DVPANEL_UNNAMEDTABLE1Container = this.DVPANEL_UNNAMEDTABLE1Container;
   DVPANEL_UNNAMEDTABLE1Container.setProp("Class", "Class", "", "char");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Width", "Width", "100%", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Height", "Height", "100", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Title", "Title", "瀹℃壒鎯呭喌缁熻", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_UNNAMEDTABLE1Container.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setProp("Visible", "Visible", true, "bool");
   DVPANEL_UNNAMEDTABLE1Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_UNNAMEDTABLE1Container);
   this.VHIGHCHARTSCOUNTContainer = gx.uc.getNew(this, 28, 0, "sgHighChartsBasic", "VHIGHCHARTSCOUNTContainer", "Vhighchartscount", "VHIGHCHARTSCOUNT");
   var VHIGHCHARTSCOUNTContainer = this.VHIGHCHARTSCOUNTContainer;
   VHIGHCHARTSCOUNTContainer.setProp("Class", "Class", "", "char");
   VHIGHCHARTSCOUNTContainer.setProp("Enabled", "Enabled", true, "boolean");
   VHIGHCHARTSCOUNTContainer.setProp("Width", "Width", "600", "str");
   VHIGHCHARTSCOUNTContainer.setProp("Height", "Height", "450", "str");
   VHIGHCHARTSCOUNTContainer.addV2CFunction('AV31tEncounterCount', "vTENCOUNTERCOUNT", 'SetOptionJson');
   VHIGHCHARTSCOUNTContainer.addC2VFunction(function(UC) { UC.ParentObject.AV31tEncounterCount=UC.GetOptionJson();gx.fn.setControlValue("vTENCOUNTERCOUNT",UC.ParentObject.AV31tEncounterCount); });
   VHIGHCHARTSCOUNTContainer.setProp("SwitchType", "Switchtype", "none", "str");
   VHIGHCHARTSCOUNTContainer.setProp("Visible", "Visible", true, "bool");
   VHIGHCHARTSCOUNTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(VHIGHCHARTSCOUNTContainer);
   this.DVPANEL_UNNAMEDTABLE2Container = gx.uc.getNew(this, 21, 0, "BootstrapPanel", "DVPANEL_UNNAMEDTABLE2Container", "Dvpanel_unnamedtable2", "DVPANEL_UNNAMEDTABLE2");
   var DVPANEL_UNNAMEDTABLE2Container = this.DVPANEL_UNNAMEDTABLE2Container;
   DVPANEL_UNNAMEDTABLE2Container.setProp("Class", "Class", "", "char");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Width", "Width", "100%", "str");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Height", "Height", "100", "str");
   DVPANEL_UNNAMEDTABLE2Container.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_UNNAMEDTABLE2Container.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Title", "Title", "褰曞叆閲?, "str");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Collapsible", "Collapsible", true, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_UNNAMEDTABLE2Container.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setProp("Visible", "Visible", true, "bool");
   DVPANEL_UNNAMEDTABLE2Container.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_UNNAMEDTABLE2Container);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"DVPANEL_UNNAMEDTABLE1_CELL",grid:0};
   GXValidFnc[9]={ id: 9, fld:"HTML_DVPANEL_UNNAMEDTABLE1",grid:0};
   GXValidFnc[12]={ id: 12, fld:"LAYOUT_UNNAMEDTABLE1",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"DVPANEL_UNNAMEDTABLE2_CELL",grid:0};
   GXValidFnc[20]={ id: 20, fld:"HTML_DVPANEL_UNNAMEDTABLE2",grid:0};
   GXValidFnc[23]={ id: 23, fld:"LAYOUT_UNNAMEDTABLE2",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"UNNAMEDTABLE2",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   this.AV42tSituation = "" ;
   this.AV31tEncounterCount = "" ;
   this.A87JC_ProviderID = 0 ;
   this.A89JC_ProviderName = "" ;
   this.Events = {"e137v2_client": ["ENTER", true] ,"e147v2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A89JC_ProviderName',fld:'JC_PROVIDERNAME',pic:''},{av:'AV32tMonthName',fld:'vTMONTHNAME',pic:''},{av:'AV30tCountName',fld:'vTCOUNTNAME',pic:''}],[{av:'AV32tMonthName',fld:'vTMONTHNAME',pic:''},{av:'AV30tCountName',fld:'vTCOUNTNAME',pic:''},{av:'AV31tEncounterCount',fld:'vTENCOUNTERCOUNT',pic:''},{av:'AV42tSituation',fld:'vTSITUATION',pic:''},{av:'gx.fn.getCtrlProperty("DVPANEL_UNNAMEDTABLE1_CELL","Class")',ctrl:'DVPANEL_UNNAMEDTABLE1_CELL',prop:'Class'},{av:'gx.fn.getCtrlProperty("DVPANEL_UNNAMEDTABLE2_CELL","Class")',ctrl:'DVPANEL_UNNAMEDTABLE2_CELL',prop:'Class'}]];
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.homeback);
