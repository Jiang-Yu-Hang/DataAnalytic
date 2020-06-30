/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:22.70
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secroleview', false, function () {
   this.ServerClass =  "wwpbaseobjects.secroleview" ;
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
      this.A4SecRoleId=gx.fn.getIntegerValue("SECROLEID",',') ;
      this.AV14LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV15SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV10SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV10SecRoleId=gx.fn.getIntegerValue("vSECROLEID",',') ;
      this.AV14LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV15SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("CELL_GENERAL","Visible", true );
      if ( this.AV14LoadAllTabs || ( this.AV15SelectedTabCode == "" ) || ( this.AV15SelectedTabCode == "General" ) )
      {
         this.createWebComponent('Generalwc','WWPBaseObjects.SecRoleGeneral',[this.AV10SecRoleId]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "瑙掕壊淇℃伅" );
         if ( ( this.AV15SelectedTabCode == "" ) || ( this.AV15SelectedTabCode == "General" ) )
         {
            gx.fn.setCtrlProperty("CELL_GENERAL","Visible", false );
         }
      }
      gx.fn.setCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible", true );
      if ( this.AV14LoadAllTabs || ( this.AV15SelectedTabCode == "SecFunctionalityRole" ) )
      {
         this.createWebComponent('Secfunctionalityrolewc','WWPBaseObjects.SecRoleSecFunctionalityRoleWC',[this.AV10SecRoleId]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "鏉冮檺" );
         if ( this.AV15SelectedTabCode == "SecFunctionalityRole" )
         {
            gx.fn.setCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible", false );
         }
      }
      gx.fn.setCtrlProperty("CELL_SECUSERROLE","Visible", true );
      if ( this.AV14LoadAllTabs || ( this.AV15SelectedTabCode == "SecUserRole" ) )
      {
         this.createWebComponent('Secuserrolewc','WWPBaseObjects.SecRoleSecUserRoleWC',[this.AV10SecRoleId]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "鐢ㄦ埛" );
         if ( this.AV15SelectedTabCode == "SecUserRole" )
         {
            gx.fn.setCtrlProperty("CELL_SECUSERROLE","Visible", false );
         }
      }
   };
   this.e110u1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_DELETEROLEContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e120u1_client=function()
   {
      this.clearMessages();
      this.call("wwpbaseobjects.secroleww.aspx", []);
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e190u1_client=function()
   {
      this.clearMessages();
      this.AV15SelectedTabCode =  this.TABSContainer.ActivePageControlName  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e130u1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(1) ;
      this.AV15SelectedTabCode =  "General"  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e140u1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(2) ;
      this.AV15SelectedTabCode =  "SecFunctionalityRole"  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e150u1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(3) ;
      this.AV15SelectedTabCode =  "SecUserRole"  ;
      this.AV14LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e160u2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE", false, null, true, true);
   };
   this.e200u2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e210u2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,24,25,27,28,29,32,33,35,36,37,40,41,43,44,45,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62];
   this.GXLastCtrlId =62;
   this.TABSContainer = gx.uc.getNew(this, 22, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 3, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e190u1_client);
   this.setUserControl(TABSContainer);
   this.DVELOP_CONFIRMPANEL_DELETEROLEContainer = gx.uc.getNew(this, 65, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_DELETEROLEContainer", "Dvelop_confirmpanel_deleterole", "DVELOP_CONFIRMPANEL_DELETEROLE");
   var DVELOP_CONFIRMPANEL_DELETEROLEContainer = this.DVELOP_CONFIRMPANEL_DELETEROLEContainer;
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("ConfirmationText", "Confirmationtext", "纭鍒犻櫎锛?, "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_DELETEROLEContainer.addEventHandler("Close", this.e160u2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_DELETEROLEContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"BTNDELETEROLE",grid:0};
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
   GXValidFnc[32]={ id: 32, fld:"SECFUNCTIONALITYROLE_TITLE", format:0,grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"UNNAMEDTABLESECFUNCTIONALITYROLE",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"SECUSERROLE_TITLE", format:0,grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"UNNAMEDTABLESECUSERROLE",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"CELL_GENERAL",grid:0};
   GXValidFnc[52]={ id: 52, fld:"BTNGENERAL",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id: 54, fld:"CELL_SECFUNCTIONALITYROLE",grid:0};
   GXValidFnc[55]={ id: 55, fld:"BTNSECFUNCTIONALITYROLE",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"CELL_SECUSERROLE",grid:0};
   GXValidFnc[58]={ id: 58, fld:"BTNSECUSERROLE",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[62]={ id: 62, fld:"TABLEDVELOP_CONFIRMPANEL_DELETEROLE",grid:0};
   this.AV10SecRoleId = 0 ;
   this.AV8TabCode = "" ;
   this.A4SecRoleId = 0 ;
   this.A13SecRoleName = "" ;
   this.AV14LoadAllTabs = false ;
   this.AV15SelectedTabCode = "" ;
   this.Events = {"e160u2_client": ["DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE", true] ,"e200u2_client": ["ENTER", true] ,"e210u2_client": ["CANCEL", true] ,"e110u1_client": ["'DODELETEROLE'", false] ,"e120u1_client": ["'DORETURN'", false] ,"e190u1_client": ["TABS.TABCHANGED", false] ,"e130u1_client": ["'GENERAL'", false] ,"e140u1_client": ["'SECFUNCTIONALITYROLE'", false] ,"e150u1_client": ["'SECUSERROLE'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'A13SecRoleName',fld:'SECROLENAME',pic:''},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{ctrl:'FORM',prop:'Caption'},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["'DODELETEROLE'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_DELETEROLEContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEROLE',prop:'Result'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}],[]];
   this.EvtParms["'DORETURN'"] = [[],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["'GENERAL'"] = [[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["'SECFUNCTIONALITYROLE'"] = [[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.EvtParms["'SECUSERROLE'"] = [[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}],[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_SECFUNCTIONALITYROLE","Visible")',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'gx.fn.getCtrlProperty("CELL_SECUSERROLE","Visible")',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]];
   this.setVCMap("A4SecRoleId", "SECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV14LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV15SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10SecRoleId", "vSECROLEID", 0, "int", 4, 0);
   this.setVCMap("AV14LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV15SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0030" , lvl: 1 });
   this.setComponent({id: "SECFUNCTIONALITYROLEWC" ,GXClass: null , Prefix: "W0038" , lvl: 1 });
   this.setComponent({id: "SECUSERROLEWC" ,GXClass: null , Prefix: "W0046" , lvl: 1 });
});
gx.createParentObj(wwpbaseobjects.secroleview);
