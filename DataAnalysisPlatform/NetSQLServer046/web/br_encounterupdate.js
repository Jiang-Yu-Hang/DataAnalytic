/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:58:56.11
*/
gx.evt.autoSkip = false;
gx.define('br_encounterupdate', false, function () {
   this.ServerClass =  "br_encounterupdate" ;
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
      this.AV10BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV6WWPContext=gx.fn.getControlValue("vWWPCONTEXT") ;
      this.AV18tPageReturn=gx.fn.getControlValue("vTPAGERETURN") ;
      this.AV16BCBR_Encounter=gx.fn.getControlValue("vBCBR_ENCOUNTER") ;
      this.A19BR_EncounterID=gx.fn.getIntegerValue("BR_ENCOUNTERID",',') ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.e111x1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_CHECKContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e121x1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_RECHECKContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e131x1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_SUBMITContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e151x2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_CHECK.CLOSE", false, null, true, true);
   };
   this.e161x2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_RECHECK.CLOSE", false, null, true, true);
   };
   this.e171x2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_SUBMIT.CLOSE", false, null, true, true);
   };
   this.e211x2_client=function()
   {
      return this.executeServerEvent("'DORETURN'", false, null, false, false);
   };
   this.e141x2_client=function()
   {
      return this.executeServerEvent("TABS.TABCHANGED", false, null, true, true);
   };
   this.e221x2_client=function()
   {
      return this.executeServerEvent("'BR_ENCOUNTER'", false, null, false, false);
   };
   this.e231x2_client=function()
   {
      return this.executeServerEvent("'BR_DEMOGRAPHICS'", false, null, false, false);
   };
   this.e241x2_client=function()
   {
      return this.executeServerEvent("'BR_BEHAVIOR'", false, null, false, false);
   };
   this.e251x2_client=function()
   {
      return this.executeServerEvent("'BR_COMORBIDITY'", false, null, false, false);
   };
   this.e261x2_client=function()
   {
      return this.executeServerEvent("'BR_DEATH'", false, null, false, false);
   };
   this.e271x2_client=function()
   {
      return this.executeServerEvent("'BR_VITAL'", false, null, false, false);
   };
   this.e281x2_client=function()
   {
      return this.executeServerEvent("'BR_DIAGNOSIS'", false, null, false, false);
   };
   this.e291x2_client=function()
   {
      return this.executeServerEvent("'BR_LAB'", false, null, false, false);
   };
   this.e301x2_client=function()
   {
      return this.executeServerEvent("'BR_MEDICATION'", false, null, false, false);
   };
   this.e311x2_client=function()
   {
      return this.executeServerEvent("'BR_SCHEME'", false, null, false, false);
   };
   this.e321x2_client=function()
   {
      return this.executeServerEvent("'BR_PROCEDURE'", false, null, false, false);
   };
   this.e331x2_client=function()
   {
      return this.executeServerEvent("'BR_MEDICALIMAGING'", false, null, false, false);
   };
   this.e341x2_client=function()
   {
      return this.executeServerEvent("'BR_PATHOLOGY'", false, null, false, false);
   };
   this.e351x2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e361x2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,28,29,31,32,33,36,37,39,40,41,44,45,47,48,49,52,53,55,56,57,60,61,63,64,65,68,69,71,72,73,76,77,79,80,81,84,85,87,88,89,92,93,95,96,97,100,101,103,104,105,108,109,111,112,113,116,117,119,120,121,124,125,127,128,129,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,175,176,181,186];
   this.GXLastCtrlId =186;
   this.TABSContainer = gx.uc.getNew(this, 26, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 13, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e141x2_client);
   this.setUserControl(TABSContainer);
   this.DVELOP_CONFIRMPANEL_SUBMITContainer = gx.uc.getNew(this, 189, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_SUBMITContainer", "Dvelop_confirmpanel_submit", "DVELOP_CONFIRMPANEL_SUBMIT");
   var DVELOP_CONFIRMPANEL_SUBMITContainer = this.DVELOP_CONFIRMPANEL_SUBMITContainer;
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_SUBMITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_SUBMITContainer.addEventHandler("Close", this.e171x2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_SUBMITContainer);
   this.DVELOP_CONFIRMPANEL_RECHECKContainer = gx.uc.getNew(this, 184, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_RECHECKContainer", "Dvelop_confirmpanel_recheck", "DVELOP_CONFIRMPANEL_RECHECK");
   var DVELOP_CONFIRMPANEL_RECHECKContainer = this.DVELOP_CONFIRMPANEL_RECHECKContainer;
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_RECHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_RECHECKContainer.addEventHandler("Close", this.e161x2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_RECHECKContainer);
   this.DVELOP_CONFIRMPANEL_CHECKContainer = gx.uc.getNew(this, 179, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_CHECKContainer", "Dvelop_confirmpanel_check", "DVELOP_CONFIRMPANEL_CHECK");
   var DVELOP_CONFIRMPANEL_CHECKContainer = this.DVELOP_CONFIRMPANEL_CHECKContainer;
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_CHECKContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_CHECKContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_CHECKContainer.addEventHandler("Close", this.e151x2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_CHECKContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"BTNCHECK",grid:0};
   GXValidFnc[12]={ id: 12, fld:"",grid:0};
   GXValidFnc[13]={ id: 13, fld:"BTNRECHECK",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"BTNSUBMIT",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"BTNRETURN",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TXTTABTITLE", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"BR_ENCOUNTER_TITLE", format:0,grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_ENCOUNTER",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"BR_DEMOGRAPHICS_TITLE", format:0,grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"UNNAMEDTABLEBR_DEMOGRAPHICS",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"BR_BEHAVIOR_TITLE", format:0,grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"UNNAMEDTABLEBR_BEHAVIOR",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[52]={ id: 52, fld:"BR_COMORBIDITY_TITLE", format:0,grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[55]={ id: 55, fld:"UNNAMEDTABLEBR_COMORBIDITY",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"BR_DEATH_TITLE", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[63]={ id: 63, fld:"UNNAMEDTABLEBR_DEATH",grid:0};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"BR_VITAL_TITLE", format:0,grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[71]={ id: 71, fld:"UNNAMEDTABLEBR_VITAL",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[76]={ id: 76, fld:"BR_DIAGNOSIS_TITLE", format:0,grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[79]={ id: 79, fld:"UNNAMEDTABLEBR_DIAGNOSIS",grid:0};
   GXValidFnc[80]={ id: 80, fld:"",grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[84]={ id: 84, fld:"BR_LAB_TITLE", format:0,grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[87]={ id: 87, fld:"UNNAMEDTABLEBR_LAB",grid:0};
   GXValidFnc[88]={ id: 88, fld:"",grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[92]={ id: 92, fld:"BR_MEDICATION_TITLE", format:0,grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[95]={ id: 95, fld:"UNNAMEDTABLEBR_MEDICATION",grid:0};
   GXValidFnc[96]={ id: 96, fld:"",grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[100]={ id: 100, fld:"BR_SCHEME_TITLE", format:0,grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[103]={ id: 103, fld:"UNNAMEDTABLEBR_SCHEME",grid:0};
   GXValidFnc[104]={ id: 104, fld:"",grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[108]={ id: 108, fld:"BR_PROCEDURE_TITLE", format:0,grid:0};
   GXValidFnc[109]={ id: 109, fld:"",grid:0};
   GXValidFnc[111]={ id: 111, fld:"UNNAMEDTABLEBR_PROCEDURE",grid:0};
   GXValidFnc[112]={ id: 112, fld:"",grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[116]={ id: 116, fld:"BR_MEDICALIMAGING_TITLE", format:0,grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[119]={ id: 119, fld:"UNNAMEDTABLEBR_MEDICALIMAGING",grid:0};
   GXValidFnc[120]={ id: 120, fld:"",grid:0};
   GXValidFnc[121]={ id: 121, fld:"",grid:0};
   GXValidFnc[124]={ id: 124, fld:"BR_PATHOLOGY_TITLE", format:0,grid:0};
   GXValidFnc[125]={ id: 125, fld:"",grid:0};
   GXValidFnc[127]={ id: 127, fld:"UNNAMEDTABLEBR_PATHOLOGY",grid:0};
   GXValidFnc[128]={ id: 128, fld:"",grid:0};
   GXValidFnc[129]={ id: 129, fld:"",grid:0};
   GXValidFnc[131]={ id: 131, fld:"",grid:0};
   GXValidFnc[132]={ id: 132, fld:"",grid:0};
   GXValidFnc[133]={ id: 133, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[134]={ id: 134, fld:"",grid:0};
   GXValidFnc[135]={ id: 135, fld:"CELL_BR_ENCOUNTER",grid:0};
   GXValidFnc[136]={ id: 136, fld:"BTNBR_ENCOUNTER",grid:0};
   GXValidFnc[137]={ id: 137, fld:"",grid:0};
   GXValidFnc[138]={ id: 138, fld:"CELL_BR_DEMOGRAPHICS",grid:0};
   GXValidFnc[139]={ id: 139, fld:"BTNBR_DEMOGRAPHICS",grid:0};
   GXValidFnc[140]={ id: 140, fld:"",grid:0};
   GXValidFnc[141]={ id: 141, fld:"CELL_BR_BEHAVIOR",grid:0};
   GXValidFnc[142]={ id: 142, fld:"BTNBR_BEHAVIOR",grid:0};
   GXValidFnc[143]={ id: 143, fld:"",grid:0};
   GXValidFnc[144]={ id: 144, fld:"CELL_BR_COMORBIDITY",grid:0};
   GXValidFnc[145]={ id: 145, fld:"BTNBR_COMORBIDITY",grid:0};
   GXValidFnc[146]={ id: 146, fld:"",grid:0};
   GXValidFnc[147]={ id: 147, fld:"CELL_BR_DEATH",grid:0};
   GXValidFnc[148]={ id: 148, fld:"BTNBR_DEATH",grid:0};
   GXValidFnc[149]={ id: 149, fld:"",grid:0};
   GXValidFnc[150]={ id: 150, fld:"CELL_BR_VITAL",grid:0};
   GXValidFnc[151]={ id: 151, fld:"BTNBR_VITAL",grid:0};
   GXValidFnc[152]={ id: 152, fld:"",grid:0};
   GXValidFnc[153]={ id: 153, fld:"CELL_BR_DIAGNOSIS",grid:0};
   GXValidFnc[154]={ id: 154, fld:"BTNBR_DIAGNOSIS",grid:0};
   GXValidFnc[155]={ id: 155, fld:"",grid:0};
   GXValidFnc[156]={ id: 156, fld:"CELL_BR_LAB",grid:0};
   GXValidFnc[157]={ id: 157, fld:"BTNBR_LAB",grid:0};
   GXValidFnc[158]={ id: 158, fld:"",grid:0};
   GXValidFnc[159]={ id: 159, fld:"CELL_BR_MEDICATION",grid:0};
   GXValidFnc[160]={ id: 160, fld:"BTNBR_MEDICATION",grid:0};
   GXValidFnc[161]={ id: 161, fld:"",grid:0};
   GXValidFnc[162]={ id: 162, fld:"CELL_BR_SCHEME",grid:0};
   GXValidFnc[163]={ id: 163, fld:"BTNBR_SCHEME",grid:0};
   GXValidFnc[164]={ id: 164, fld:"",grid:0};
   GXValidFnc[165]={ id: 165, fld:"CELL_BR_PROCEDURE",grid:0};
   GXValidFnc[166]={ id: 166, fld:"BTNBR_PROCEDURE",grid:0};
   GXValidFnc[167]={ id: 167, fld:"",grid:0};
   GXValidFnc[168]={ id: 168, fld:"CELL_BR_MEDICALIMAGING",grid:0};
   GXValidFnc[169]={ id: 169, fld:"BTNBR_MEDICALIMAGING",grid:0};
   GXValidFnc[170]={ id: 170, fld:"",grid:0};
   GXValidFnc[171]={ id: 171, fld:"CELL_BR_PATHOLOGY",grid:0};
   GXValidFnc[172]={ id: 172, fld:"BTNBR_PATHOLOGY",grid:0};
   GXValidFnc[173]={ id: 173, fld:"",grid:0};
   GXValidFnc[174]={ id: 174, fld:"",grid:0};
   GXValidFnc[175]={ id: 175, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[176]={ id: 176, fld:"TABLEDVELOP_CONFIRMPANEL_CHECK",grid:0};
   GXValidFnc[181]={ id: 181, fld:"TABLEDVELOP_CONFIRMPANEL_RECHECK",grid:0};
   GXValidFnc[186]={ id: 186, fld:"TABLEDVELOP_CONFIRMPANEL_SUBMIT",grid:0};
   this.AV10BR_EncounterID = 0 ;
   this.AV8TabCode = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV6WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV18tPageReturn = "" ;
   this.AV16BCBR_Encounter = {BR_EncounterID:0,BR_Encounter_EncID:0,BR_Encounter_Department:"",BR_Encounter_Department_Code:"",BR_Encounter_Departmentadm:"",BR_Encounter_Departmentadm_Code:"",BR_Encounter_Departmentdisch:"",BR_Encounter_Departmentdisch_Code:"",BR_Encounter_ENCType:"",BR_Encounter_ENCType_Code:"",BR_Encounter_AdmitDate:gx.date.nullDate(),BR_Encounter_AdmitSource:"",BR_Encounter_AdmitSource_Code:"",BR_Encounter_DischargeDate:gx.date.nullDate(),BR_Encounter_DischargeStatus:"",BR_Encounter_DischargeStatus_Code:"",BR_Encounter_Insurance:"",BR_Encounter_Insurance_Code:"",BR_Encounter_Status:0,BR_Information_ID:0,BR_Information_PatientNo:"",BAS_TenantTenantCode:"",BR_Encounter_CrtDate:gx.date.nullDate(),BR_Encounter_UpdDate:gx.date.nullDate(),BR_Encounter_CrtUser:"",BR_Encounter_CrtDisplayName:"",BR_Encounter_UpdUser:"",BR_Encounter_IsDLT:false,BR_Encounter_SubmitUser:"",BR_Encounter_Reason:"",BR_Encounter_SubmitDate:gx.date.nullDate(),BR_Encounter_RecheckUser:"",BR_Encounter_FReason:"",BR_Encounter_RecheckDate:gx.date.nullDate(),BR_Encounter_Approver:"",BR_Encounter_ApproveDate:gx.date.nullDate(),BR_Encounter_IsRandApprove:false,BR_Encounter_IsRandApprover:"",BR_Encounter_IsRandNoApprover:"",BR_Encounter_IsRandApproveDate:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate:gx.date.nullDate(),BR_Encounter_IsRandRecheck:false,BR_Encounter_IsRandRecheckr:"",BR_Encounter_IsRandNoRecheckr:"",BR_Encounter_IsRandRecheckDate:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate:gx.date.nullDate(),BR_Encounter_IsUpdate:false,BR_Encounter_Datasource:0,EncounterIDEncrypt:"",Mode:"",Initialized:0,BR_EncounterID_Z:0,BR_Encounter_EncID_Z:0,BR_Encounter_Department_Z:"",BR_Encounter_Department_Code_Z:"",BR_Encounter_Departmentadm_Z:"",BR_Encounter_Departmentadm_Code_Z:"",BR_Encounter_Departmentdisch_Z:"",BR_Encounter_Departmentdisch_Code_Z:"",BR_Encounter_ENCType_Z:"",BR_Encounter_ENCType_Code_Z:"",BR_Encounter_AdmitDate_Z:gx.date.nullDate(),BR_Encounter_AdmitSource_Z:"",BR_Encounter_AdmitSource_Code_Z:"",BR_Encounter_DischargeDate_Z:gx.date.nullDate(),BR_Encounter_DischargeStatus_Z:"",BR_Encounter_DischargeStatus_Code_Z:"",BR_Encounter_Insurance_Z:"",BR_Encounter_Insurance_Code_Z:"",BR_Encounter_Status_Z:0,BR_Information_ID_Z:0,BR_Information_PatientNo_Z:"",BAS_TenantTenantCode_Z:"",BR_Encounter_CrtDate_Z:gx.date.nullDate(),BR_Encounter_UpdDate_Z:gx.date.nullDate(),BR_Encounter_CrtUser_Z:"",BR_Encounter_CrtDisplayName_Z:"",BR_Encounter_UpdUser_Z:"",BR_Encounter_IsDLT_Z:false,BR_Encounter_SubmitUser_Z:"",BR_Encounter_Reason_Z:"",BR_Encounter_SubmitDate_Z:gx.date.nullDate(),BR_Encounter_RecheckUser_Z:"",BR_Encounter_FReason_Z:"",BR_Encounter_RecheckDate_Z:gx.date.nullDate(),BR_Encounter_Approver_Z:"",BR_Encounter_ApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandApprove_Z:false,BR_Encounter_IsRandApprover_Z:"",BR_Encounter_IsRandNoApprover_Z:"",BR_Encounter_IsRandApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandRecheck_Z:false,BR_Encounter_IsRandRecheckr_Z:"",BR_Encounter_IsRandNoRecheckr_Z:"",BR_Encounter_IsRandRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsUpdate_Z:false,BR_Encounter_Datasource_Z:0,EncounterIDEncrypt_Z:""} ;
   this.AV11LoadAllTabs = false ;
   this.AV12SelectedTabCode = "" ;
   this.Events = {"e151x2_client": ["DVELOP_CONFIRMPANEL_CHECK.CLOSE", true] ,"e161x2_client": ["DVELOP_CONFIRMPANEL_RECHECK.CLOSE", true] ,"e171x2_client": ["DVELOP_CONFIRMPANEL_SUBMIT.CLOSE", true] ,"e211x2_client": ["'DORETURN'", true] ,"e141x2_client": ["TABS.TABCHANGED", true] ,"e221x2_client": ["'BR_ENCOUNTER'", true] ,"e231x2_client": ["'BR_DEMOGRAPHICS'", true] ,"e241x2_client": ["'BR_BEHAVIOR'", true] ,"e251x2_client": ["'BR_COMORBIDITY'", true] ,"e261x2_client": ["'BR_DEATH'", true] ,"e271x2_client": ["'BR_VITAL'", true] ,"e281x2_client": ["'BR_DIAGNOSIS'", true] ,"e291x2_client": ["'BR_LAB'", true] ,"e301x2_client": ["'BR_MEDICATION'", true] ,"e311x2_client": ["'BR_SCHEME'", true] ,"e321x2_client": ["'BR_PROCEDURE'", true] ,"e331x2_client": ["'BR_MEDICALIMAGING'", true] ,"e341x2_client": ["'BR_PATHOLOGY'", true] ,"e351x2_client": ["ENTER", true] ,"e361x2_client": ["CANCEL", true] ,"e111x1_client": ["'DOCHECK'", false] ,"e121x1_client": ["'DORECHECK'", false] ,"e131x1_client": ["'DOSUBMIT'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{ctrl:'BTNCHECK',prop:'Visible'},{ctrl:'BTNSUBMIT',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{ctrl:'FORM',prop:'Caption'},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{ctrl:'BTNSUBMIT',prop:'Visible'},{ctrl:'BTNCHECK',prop:'Visible'},{ctrl:'BTNRECHECK',prop:'Visible'},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["'DOCHECK'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_CHECK.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_CHECKContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_CHECK',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DORECHECK'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_RECHECK.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_RECHECKContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_RECHECK',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DOSUBMIT'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_SUBMIT.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_SUBMITContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_SUBMIT',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DORETURN'"] = [[{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_ENCOUNTER'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_DEMOGRAPHICS'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_BEHAVIOR'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_COMORBIDITY'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_DEATH'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_VITAL'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_DIAGNOSIS'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_LAB'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_MEDICATION'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_SCHEME'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_PROCEDURE'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_MEDICALIMAGING'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_PATHOLOGY'"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_BR_ENCOUNTER","Visible")',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEMOGRAPHICS","Visible")',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_BEHAVIOR","Visible")',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_COMORBIDITY","Visible")',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DEATH","Visible")',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_VITAL","Visible")',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.setVCMap("AV10BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV6WWPContext", "vWWPCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("AV18tPageReturn", "vTPAGERETURN", 0, "svchar", 100, 0);
   this.setVCMap("AV16BCBR_Encounter", "vBCBR_ENCOUNTER", 0, "BR_Encounter", 0, 0);
   this.setVCMap("A19BR_EncounterID", "BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "BR_ENCOUNTERWC" ,GXClass: null , Prefix: "W0034" , lvl: 1 });
   this.setComponent({id: "BR_DEMOGRAPHICSWC" ,GXClass: null , Prefix: "W0042" , lvl: 1 });
   this.setComponent({id: "BR_BEHAVIORWC" ,GXClass: null , Prefix: "W0050" , lvl: 1 });
   this.setComponent({id: "BR_COMORBIDITYWC" ,GXClass: null , Prefix: "W0058" , lvl: 1 });
   this.setComponent({id: "BR_DEATHWC" ,GXClass: null , Prefix: "W0066" , lvl: 1 });
   this.setComponent({id: "BR_VITALWC" ,GXClass: null , Prefix: "W0074" , lvl: 1 });
   this.setComponent({id: "BR_DIAGNOSISWC" ,GXClass: null , Prefix: "W0082" , lvl: 1 });
   this.setComponent({id: "BR_LABWC" ,GXClass: null , Prefix: "W0090" , lvl: 1 });
   this.setComponent({id: "BR_MEDICATIONWC" ,GXClass: null , Prefix: "W0098" , lvl: 1 });
   this.setComponent({id: "BR_SCHEMEWC" ,GXClass: null , Prefix: "W0106" , lvl: 1 });
   this.setComponent({id: "BR_PROCEDUREWC" ,GXClass: null , Prefix: "W0114" , lvl: 1 });
   this.setComponent({id: "BR_MEDICALIMAGINGWC" ,GXClass: null , Prefix: "W0122" , lvl: 1 });
   this.setComponent({id: "BR_PATHOLOGYWC" ,GXClass: null , Prefix: "W0130" , lvl: 1 });
});
gx.createParentObj(br_encounterupdate);
