/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:18.63
*/
gx.evt.autoSkip = false;
gx.define('jc_providerview', false, function () {
   this.ServerClass =  "jc_providerview" ;
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
      this.AV10JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
      this.AV10JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
   };
   this.s112_client=function()
   {
      gx.fn.setCtrlProperty("CELL_GENERAL","Visible", true );
      if ( this.AV11LoadAllTabs || ( this.AV12SelectedTabCode == "" ) || ( this.AV12SelectedTabCode == "General" ) )
      {
         this.createWebComponent('Generalwc','JC_ProviderGeneral',[this.AV10JC_ProviderID]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "General" );
         if ( ( this.AV12SelectedTabCode == "" ) || ( this.AV12SelectedTabCode == "General" ) )
         {
            gx.fn.setCtrlProperty("CELL_GENERAL","Visible", false );
         }
      }
      gx.fn.setCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible", true );
      if ( this.AV11LoadAllTabs || ( this.AV12SelectedTabCode == "JC_ProviderSecUser" ) )
      {
         this.createWebComponent('Jc_providersecuserwc','JC_ProviderJC_ProviderSecUserWC',[this.AV10JC_ProviderID]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "鍖婚櫌璐﹀彿鍏崇郴琛? );
         if ( this.AV12SelectedTabCode == "JC_ProviderSecUser" )
         {
            gx.fn.setCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible", false );
         }
      }
      gx.fn.setCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible", true );
      if ( this.AV11LoadAllTabs || ( this.AV12SelectedTabCode == "JC_Provider_Br_Information" ) )
      {
         this.createWebComponent('Jc_provider_br_informationwc','JC_ProviderJC_Provider_Br_InformationWC',[this.AV10JC_ProviderID]);
         gx.fn.setCtrlProperty("TXTTABTITLE","Caption", "鎮ｈ€呭垎闄㈣〃" );
         if ( this.AV12SelectedTabCode == "JC_Provider_Br_Information" )
         {
            gx.fn.setCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible", false );
         }
      }
   };
   this.e168h1_client=function()
   {
      this.clearMessages();
      this.AV12SelectedTabCode =  this.TABSContainer.ActivePageControlName  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e118h1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(1) ;
      this.AV12SelectedTabCode =  "General"  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e128h1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(2) ;
      this.AV12SelectedTabCode =  "JC_ProviderSecUser"  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e138h1_client=function()
   {
      this.clearMessages();
      this.TABSContainer.SelectTab(3) ;
      this.AV12SelectedTabCode =  "JC_Provider_Br_Information"  ;
      this.AV11LoadAllTabs =  false  ;
      this.s112_client();
      this.refreshOutputs([{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]);
      return gx.$.Deferred().resolve();
   };
   this.e178h2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e188h2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,20,21,23,24,25,28,29,31,32,33,36,37,39,40,41,43,44,45,46,47,48,49,50,51,52,53,54];
   this.GXLastCtrlId =54;
   this.TABSContainer = gx.uc.getNew(this, 18, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 3, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e168h1_client);
   this.setUserControl(TABSContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"WORKWITHLINK", format:0,grid:0};
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
   GXValidFnc[28]={ id: 28, fld:"JC_PROVIDERSECUSER_TITLE", format:0,grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEJC_PROVIDERSECUSER",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"JC_PROVIDER_BR_INFORMATION_TITLE", format:0,grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"UNNAMEDTABLEJC_PROVIDER_BR_INFORMATION",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"CELL_GENERAL",grid:0};
   GXValidFnc[48]={ id: 48, fld:"BTNGENERAL",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"CELL_JC_PROVIDERSECUSER",grid:0};
   GXValidFnc[51]={ id: 51, fld:"BTNJC_PROVIDERSECUSER",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"CELL_JC_PROVIDER_BR_INFORMATION",grid:0};
   GXValidFnc[54]={ id: 54, fld:"BTNJC_PROVIDER_BR_INFORMATION",grid:0};
   this.AV10JC_ProviderID = 0 ;
   this.AV8TabCode = "" ;
   this.A87JC_ProviderID = 0 ;
   this.A89JC_ProviderName = "" ;
   this.AV11LoadAllTabs = false ;
   this.AV12SelectedTabCode = "" ;
   this.Events = {"e178h2_client": ["ENTER", true] ,"e188h2_client": ["CANCEL", true] ,"e168h1_client": ["TABS.TABCHANGED", false] ,"e118h1_client": ["'GENERAL'", false] ,"e128h1_client": ["'JC_PROVIDERSECUSER'", false] ,"e138h1_client": ["'JC_PROVIDER_BR_INFORMATION'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A89JC_ProviderName',fld:'JC_PROVIDERNAME',pic:''},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'gx.fn.getCtrlProperty("WORKWITHLINK","Link")',ctrl:'WORKWITHLINK',prop:'Link'},{ctrl:'FORM',prop:'Caption'},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]];
   this.EvtParms["'GENERAL'"] = [[{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]];
   this.EvtParms["'JC_PROVIDERSECUSER'"] = [[{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]];
   this.EvtParms["'JC_PROVIDER_BR_INFORMATION'"] = [[{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDERSECUSER","Visible")',ctrl:'CELL_JC_PROVIDERSECUSER',prop:'Visible'},{ctrl:'JC_PROVIDERSECUSERWC'},{av:'gx.fn.getCtrlProperty("CELL_JC_PROVIDER_BR_INFORMATION","Visible")',ctrl:'CELL_JC_PROVIDER_BR_INFORMATION',prop:'Visible'},{ctrl:'JC_PROVIDER_BR_INFORMATIONWC'}]];
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV10JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0026" , lvl: 1 });
   this.setComponent({id: "JC_PROVIDERSECUSERWC" ,GXClass: null , Prefix: "W0034" , lvl: 1 });
   this.setComponent({id: "JC_PROVIDER_BR_INFORMATIONWC" ,GXClass: null , Prefix: "W0042" , lvl: 1 });
});
gx.createParentObj(jc_providerview);
