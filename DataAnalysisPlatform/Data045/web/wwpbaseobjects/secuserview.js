/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:9:8.22
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secuserview', false, function () {
   this.ServerClass =  "wwpbaseobjects.secuserview" ;
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
      this.AV10SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.AV14LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV15SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV10SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.AV14LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV15SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("CELL_GENERAL","Visible", true );
      if ( this.AV14LoadAllTabs || ( this.AV15SelectedTabCode == "" ) || ( this.AV15SelectedTabCode == "General" ) )
      {
         this.createWebComponent('Generalwc','WWPBaseObjects.SecUserGeneral',[this.AV10SecUserId]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "用户信息" );
         if ( ( this.AV15SelectedTabCode == "" ) || ( this.AV15SelectedTabCode == "General" ) )
         {
            gx.fn.setCtrlProperty("CELL_GENERAL","Visible", false );
         }
      }
      gx.fn.setCtrlProperty("CELL_SECUSERROLE","Visible", true );
      if ( this.AV14LoadAllTabs || ( this.AV15SelectedTabCode == "SecUserRole" ) )
      {
         this.createWebComponent('Secuserrolewc','WWPBaseObjects.SecUserSecUserRoleWC',[this.AV10SecUserId]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "角色" );
         if ( this.AV15SelectedTabCode == "SecUserRole" )
         {
            gx.fn.setCtrlProperty("CELL_SECUSERROLE","Visible", false );
         }
      }
   };
   this.e110j1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_DELETEContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e120j1_client=function()
   {
      this.clearMessages();
      this.call("wwpbaseobjects.secuserww.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e180j1_client=function()
   {
      this.clearMessages();
      this.AV15SelectedTabCode =  this.TABSContainer.ActivePageControlName  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e130j1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(1) ;
      this.AV15SelectedTabCode =  "General"  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e140j1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(2) ;
      this.AV15SelectedTabCode =  "SecUserRole"  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e150j2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_DELETE.CLOSE", false, null, true, true);
   };
   this.e190j2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e200j2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29,32,33,35,36,37,39,40,41,42,43,44,45,46,47,48,49,50,51];
   this.GXLastCtrlId =51;
   this.TABSContainer = gx.uc.getNew(this, 22, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 2, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e180j1_client);
   this.setUserControl(TABSContainer);
   this.DVELOP_CONFIRMPANEL_DELETEContainer = gx.uc.getNew(this, 54, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_DELETEContainer", "Dvelop_confirmpanel_delete", "DVELOP_CONFIRMPANEL_DELETE");
   var DVELOP_CONFIRMPANEL_DELETEContainer = this.DVELOP_CONFIRMPANEL_DELETEContainer;
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("ConfirmationText", "Confirmationtext", "确认删除该用户？", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_DELETEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_DELETEContainer.addEventHandler("Close", this.e150j2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_DELETEContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"BTNDELETE",grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"BTNRETURN",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"TXTTABTITLE", format:0,grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"UNNAMEDTABLEGENERAL",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"SECUSERROLE_TITLE", format:0,grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"UNNAMEDTABLESECUSERROLE",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"CELL_GENERAL",grid:0};
   GXValidFnc[44]={ id: 44, fld:"BTNGENERAL",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"CELL_SECUSERROLE",grid:0};
   GXValidFnc[47]={ id: 47, fld:"BTNSECUSERROLE",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TABLEDVELOP_CONFIRMPANEL_DELETE",grid:0};
   this.AV10SecUserId = 0 ;
   this.AV8TabCode = "" ;
   this.A6SecUserId = 0 ;
   this.A14SecUserName = "" ;
   this.AV14LoadAllTabs = false ;
   this.AV15SelectedTabCode = "" ;
   this.Events = {"e150j2_client": ["DVELOP_CONFIRMPANEL_DELETE.CLOSE", true] ,"e190j2_client": ["ENTER", true] ,"e200j2_client": ["CANCEL", true] ,"e110j1_client": ["'DODELETE'", false] ,"e120j1_client": ["'DORETURN'", false] ,"e180j1_client": ["TABS.TABCHANGED", false] ,"e130j1_client": ["'GENERAL'", false] ,"e140j1_client": ["'SECUSERROLE'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'A14SecUserName',fld:'SECUSERNAME',pic:''},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{ctrl:'FORM',prop:'Caption'},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["'DODELETE'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_DELETE.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_DELETEContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_DELETE',prop:'Result'},{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["'DORETURN'"] = [[],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["'GENERAL'"] = [[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["'SECUSERROLE'"] = [[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.setVCMap("AV10SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV14LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV15SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV14LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV15SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0030" , lvl: 1 });
   this.setComponent({id: "SECUSERROLEWC" ,GXClass: null , Prefix: "W0038" , lvl: 1 });
});
gx.createParentObj(wwpbaseobjects.secuserview);
