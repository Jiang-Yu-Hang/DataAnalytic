/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:40:4.79
*/
gx.evt.autoSkip = false;
gx.define('br_labview', false, function () {
   this.ServerClass =  "br_labview" ;
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
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV10BR_LabID=gx.fn.getIntegerValue("vBR_LABID",',') ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV10BR_LabID=gx.fn.getIntegerValue("vBR_LABID",',') ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("CELL_GENERAL","Visible", true );
      if ( this.AV11LoadAllTabs || ( this.AV12SelectedTabCode == "" ) || ( this.AV12SelectedTabCode == "General" ) )
      {
         this.createWebComponent('Generalwc','BR_LabGeneral',[this.AV10BR_LabID]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "瀹為獙瀹ゆ鏌? );
         if ( ( this.AV12SelectedTabCode == "" ) || ( this.AV12SelectedTabCode == "General" ) )
         {
            gx.fn.setCtrlProperty("CELL_GENERAL","Visible", false );
         }
      }
   };
   this.e153j1_client=function()
   {
      this.clearMessages();
      this.AV12SelectedTabCode =  this.TABSContainer.ActivePageControlName  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'}]);
      return gx.$.Deferred().resolve();
   };
   this.e113j1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(1) ;
      this.AV12SelectedTabCode =  "General"  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'}]);
      return gx.$.Deferred().resolve();
   };
   this.e143j2_client=function()
   {
      return this.executeServerEvent("'DORETURN'", false, null, false, false);
   };
   this.e163j2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e173j2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,27,28,29,30,31,32];
   this.GXLastCtrlId =32;
   this.TABSContainer = gx.uc.getNew(this, 18, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 1, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e153j1_client);
   this.setUserControl(TABSContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"BTNRETURN",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"TXTTABTITLE", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEGENERAL",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"CELL_GENERAL",grid:0};
   GXValidFnc[32]={ id: 32, fld:"BTNGENERAL",grid:0};
   this.AV10BR_LabID = 0 ;
   this.AV8TabCode = "" ;
   this.A101BR_LabID = 0 ;
   this.AV11LoadAllTabs = false ;
   this.AV12SelectedTabCode = "" ;
   this.Events = {"e143j2_client": ["'DORETURN'", true] ,"e163j2_client": ["ENTER", true] ,"e173j2_client": ["CANCEL", true] ,"e153j1_client": ["TABS.TABCHANGED", false] ,"e113j1_client": ["'GENERAL'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV10BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{ctrl:'FORM',prop:'Caption'},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["'DORETURN'"] = [[],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'}]];
   this.EvtParms["'GENERAL'"] = [[{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'}]];
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10BR_LabID", "vBR_LABID", 0, "int", 18, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10BR_LabID", "vBR_LABID", 0, "int", 18, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0026" , lvl: 1 });
});
gx.createParentObj(br_labview);
