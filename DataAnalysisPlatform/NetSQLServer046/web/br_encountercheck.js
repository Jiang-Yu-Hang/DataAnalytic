/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:1:17.59
*/
gx.evt.autoSkip = false;
gx.define('br_encountercheck', false, function () {
   this.ServerClass =  "br_encountercheck" ;
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
      this.AV16BCBR_Encounter=gx.fn.getControlValue("vBCBR_ENCOUNTER") ;
      this.AV27tvflag=gx.fn.getControlValue("vTVFLAG") ;
      this.AV6WWPContext=gx.fn.getControlValue("vWWPCONTEXT") ;
      this.AV25tPageReturn=gx.fn.getControlValue("vTPAGERETURN") ;
      this.AV10BR_EncounterID=gx.fn.getIntegerValue("vBR_ENCOUNTERID",',') ;
      this.AV11LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV12SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV8TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.e113s1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_CHECKContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e123s1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_CHECKRContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e133s1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e143s1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e153s1_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_EDITContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e173s2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_CHECK.CLOSE", false, null, true, true);
   };
   this.e183s2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_CHECKR.CLOSE", false, null, true, true);
   };
   this.e193s2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE", false, null, true, true);
   };
   this.e203s2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE", false, null, true, true);
   };
   this.e213s2_client=function()
   {
      return this.executeServerEvent("DVELOP_CONFIRMPANEL_EDIT.CLOSE", false, null, true, true);
   };
   this.e253s2_client=function()
   {
      return this.executeServerEvent("'DORETURN'", false, null, false, false);
   };
   this.e163s2_client=function()
   {
      return this.executeServerEvent("TABS.TABCHANGED", false, null, true, true);
   };
   this.e263s2_client=function()
   {
      return this.executeServerEvent("'GENERAL'", false, null, false, false);
   };
   this.e273s2_client=function()
   {
      return this.executeServerEvent("'CHECKDEMOGRAPHICS'", false, null, false, false);
   };
   this.e283s2_client=function()
   {
      return this.executeServerEvent("'CHECKBEHAVIOR'", false, null, false, false);
   };
   this.e293s2_client=function()
   {
      return this.executeServerEvent("'CHECKCOMORBIDITY'", false, null, false, false);
   };
   this.e303s2_client=function()
   {
      return this.executeServerEvent("'CHECKDEATH'", false, null, false, false);
   };
   this.e313s2_client=function()
   {
      return this.executeServerEvent("'CHECKVITAL'", false, null, false, false);
   };
   this.e323s2_client=function()
   {
      return this.executeServerEvent("'BR_DIAGNOSIS'", false, null, false, false);
   };
   this.e333s2_client=function()
   {
      return this.executeServerEvent("'BR_LAB'", false, null, false, false);
   };
   this.e343s2_client=function()
   {
      return this.executeServerEvent("'BR_MEDICATION'", false, null, false, false);
   };
   this.e353s2_client=function()
   {
      return this.executeServerEvent("'BR_SCHEME'", false, null, false, false);
   };
   this.e363s2_client=function()
   {
      return this.executeServerEvent("'BR_PROCEDURE'", false, null, false, false);
   };
   this.e373s2_client=function()
   {
      return this.executeServerEvent("'BR_MEDICALIMAGING'", false, null, false, false);
   };
   this.e383s2_client=function()
   {
      return this.executeServerEvent("'BR_PATHOLOGY'", false, null, false, false);
   };
   this.e393s2_client=function()
   {
      return this.executeServerEvent("'DOREFUSE'", true, null, false, false);
   };
   this.e403s2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e413s2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,32,33,35,36,37,40,41,43,44,45,48,49,51,52,53,56,57,59,60,61,64,65,67,68,69,72,73,75,76,77,80,81,83,84,85,88,89,91,92,93,96,97,99,100,101,104,105,107,108,109,112,113,115,116,117,120,121,123,124,125,128,129,131,132,133,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,185,190,195,200];
   this.GXLastCtrlId =200;
   this.TABSContainer = gx.uc.getNew(this, 30, 0, "gx.ui.controls.Tab", "TABSContainer", "Tabs", "TABS");
   var TABSContainer = this.TABSContainer;
   TABSContainer.setProp("Enabled", "Enabled", true, "boolean");
   TABSContainer.setProp("ActivePage", "Activepage", '', "int");
   TABSContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABSContainer.setProp("PageCount", "Pagecount", 13, "num");
   TABSContainer.setProp("Class", "Class", "ViewTab Tab", "str");
   TABSContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABSContainer.setProp("Visible", "Visible", true, "bool");
   TABSContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABSContainer.addEventHandler("TabChanged", this.e163s2_client);
   this.setUserControl(TABSContainer);
   this.DVELOP_CONFIRMPANEL_EDITContainer = gx.uc.getNew(this, 203, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_EDITContainer", "Dvelop_confirmpanel_edit", "DVELOP_CONFIRMPANEL_EDIT");
   var DVELOP_CONFIRMPANEL_EDITContainer = this.DVELOP_CONFIRMPANEL_EDITContainer;
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("ConfirmationText", "Confirmationtext", "杩涘叆淇敼鐣岄潰锛?, "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_EDITContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_EDITContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_EDITContainer.addEventHandler("Close", this.e213s2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_EDITContainer);
   this.DVELOP_CONFIRMPANEL_APPROVEWRONGContainer = gx.uc.getNew(this, 198, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_APPROVEWRONGContainer", "Dvelop_confirmpanel_approvewrong", "DVELOP_CONFIRMPANEL_APPROVEWRONG");
   var DVELOP_CONFIRMPANEL_APPROVEWRONGContainer = this.DVELOP_CONFIRMPANEL_APPROVEWRONGContainer;
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.addEventHandler("Close", this.e203s2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_APPROVEWRONGContainer);
   this.DVELOP_CONFIRMPANEL_APPROVERIGHTContainer = gx.uc.getNew(this, 193, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_APPROVERIGHTContainer", "Dvelop_confirmpanel_approveright", "DVELOP_CONFIRMPANEL_APPROVERIGHT");
   var DVELOP_CONFIRMPANEL_APPROVERIGHTContainer = this.DVELOP_CONFIRMPANEL_APPROVERIGHTContainer;
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.addEventHandler("Close", this.e193s2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_APPROVERIGHTContainer);
   this.DVELOP_CONFIRMPANEL_CHECKRContainer = gx.uc.getNew(this, 188, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_CHECKRContainer", "Dvelop_confirmpanel_checkr", "DVELOP_CONFIRMPANEL_CHECKR");
   var DVELOP_CONFIRMPANEL_CHECKRContainer = this.DVELOP_CONFIRMPANEL_CHECKRContainer;
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("ConfirmationText", "Confirmationtext", "纭鎻愪氦锛?, "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_CHECKRContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_CHECKRContainer.addEventHandler("Close", this.e183s2_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_CHECKRContainer);
   this.DVELOP_CONFIRMPANEL_CHECKContainer = gx.uc.getNew(this, 183, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_CHECKContainer", "Dvelop_confirmpanel_check", "DVELOP_CONFIRMPANEL_CHECK");
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
   DVELOP_CONFIRMPANEL_CHECKContainer.addEventHandler("Close", this.e173s2_client);
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
   GXValidFnc[13]={ id: 13, fld:"BTNCHECKR",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"BTNAPPROVERIGHT",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"BTNAPPROVEWRONG",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id: 19, fld:"BTNEDIT",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"BTNRETURN",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"UNNAMEDTABLEVIEWCONTAINER",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"TXTTABTITLE", format:0,grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"UNNAMEDTABLEGENERAL",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"CHECKDEMOGRAPHICS_TITLE", format:0,grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"UNNAMEDTABLECHECKDEMOGRAPHICS",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"CHECKBEHAVIOR_TITLE", format:0,grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"UNNAMEDTABLECHECKBEHAVIOR",grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"CHECKCOMORBIDITY_TITLE", format:0,grid:0};
   GXValidFnc[57]={ id: 57, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"UNNAMEDTABLECHECKCOMORBIDITY",grid:0};
   GXValidFnc[60]={ id: 60, fld:"",grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[64]={ id: 64, fld:"CHECKDEATH_TITLE", format:0,grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"UNNAMEDTABLECHECKDEATH",grid:0};
   GXValidFnc[68]={ id: 68, fld:"",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"CHECKVITAL_TITLE", format:0,grid:0};
   GXValidFnc[73]={ id: 73, fld:"",grid:0};
   GXValidFnc[75]={ id: 75, fld:"UNNAMEDTABLECHECKVITAL",grid:0};
   GXValidFnc[76]={ id: 76, fld:"",grid:0};
   GXValidFnc[77]={ id: 77, fld:"",grid:0};
   GXValidFnc[80]={ id: 80, fld:"BR_DIAGNOSIS_TITLE", format:0,grid:0};
   GXValidFnc[81]={ id: 81, fld:"",grid:0};
   GXValidFnc[83]={ id: 83, fld:"UNNAMEDTABLEBR_DIAGNOSIS",grid:0};
   GXValidFnc[84]={ id: 84, fld:"",grid:0};
   GXValidFnc[85]={ id: 85, fld:"",grid:0};
   GXValidFnc[88]={ id: 88, fld:"BR_LAB_TITLE", format:0,grid:0};
   GXValidFnc[89]={ id: 89, fld:"",grid:0};
   GXValidFnc[91]={ id: 91, fld:"UNNAMEDTABLEBR_LAB",grid:0};
   GXValidFnc[92]={ id: 92, fld:"",grid:0};
   GXValidFnc[93]={ id: 93, fld:"",grid:0};
   GXValidFnc[96]={ id: 96, fld:"BR_MEDICATION_TITLE", format:0,grid:0};
   GXValidFnc[97]={ id: 97, fld:"",grid:0};
   GXValidFnc[99]={ id: 99, fld:"UNNAMEDTABLEBR_MEDICATION",grid:0};
   GXValidFnc[100]={ id: 100, fld:"",grid:0};
   GXValidFnc[101]={ id: 101, fld:"",grid:0};
   GXValidFnc[104]={ id: 104, fld:"BR_SCHEME_TITLE", format:0,grid:0};
   GXValidFnc[105]={ id: 105, fld:"",grid:0};
   GXValidFnc[107]={ id: 107, fld:"UNNAMEDTABLEBR_SCHEME",grid:0};
   GXValidFnc[108]={ id: 108, fld:"",grid:0};
   GXValidFnc[109]={ id: 109, fld:"",grid:0};
   GXValidFnc[112]={ id: 112, fld:"BR_PROCEDURE_TITLE", format:0,grid:0};
   GXValidFnc[113]={ id: 113, fld:"",grid:0};
   GXValidFnc[115]={ id: 115, fld:"UNNAMEDTABLEBR_PROCEDURE",grid:0};
   GXValidFnc[116]={ id: 116, fld:"",grid:0};
   GXValidFnc[117]={ id: 117, fld:"",grid:0};
   GXValidFnc[120]={ id: 120, fld:"BR_MEDICALIMAGING_TITLE", format:0,grid:0};
   GXValidFnc[121]={ id: 121, fld:"",grid:0};
   GXValidFnc[123]={ id: 123, fld:"UNNAMEDTABLEBR_MEDICALIMAGING",grid:0};
   GXValidFnc[124]={ id: 124, fld:"",grid:0};
   GXValidFnc[125]={ id: 125, fld:"",grid:0};
   GXValidFnc[128]={ id: 128, fld:"BR_PATHOLOGY_TITLE", format:0,grid:0};
   GXValidFnc[129]={ id: 129, fld:"",grid:0};
   GXValidFnc[131]={ id: 131, fld:"UNNAMEDTABLEBR_PATHOLOGY",grid:0};
   GXValidFnc[132]={ id: 132, fld:"",grid:0};
   GXValidFnc[133]={ id: 133, fld:"",grid:0};
   GXValidFnc[135]={ id: 135, fld:"",grid:0};
   GXValidFnc[136]={ id: 136, fld:"",grid:0};
   GXValidFnc[137]={ id: 137, fld:"UNNAMEDTABLETABSCONTAINER",grid:0};
   GXValidFnc[138]={ id: 138, fld:"",grid:0};
   GXValidFnc[139]={ id: 139, fld:"CELL_GENERAL",grid:0};
   GXValidFnc[140]={ id: 140, fld:"BTNGENERAL",grid:0};
   GXValidFnc[141]={ id: 141, fld:"",grid:0};
   GXValidFnc[142]={ id: 142, fld:"CELL_CHECKDEMOGRAPHICS",grid:0};
   GXValidFnc[143]={ id: 143, fld:"BTNCHECKDEMOGRAPHICS",grid:0};
   GXValidFnc[144]={ id: 144, fld:"",grid:0};
   GXValidFnc[145]={ id: 145, fld:"CELL_CHECKBEHAVIOR",grid:0};
   GXValidFnc[146]={ id: 146, fld:"BTNCHECKBEHAVIOR",grid:0};
   GXValidFnc[147]={ id: 147, fld:"",grid:0};
   GXValidFnc[148]={ id: 148, fld:"CELL_CHECKCOMORBIDITY",grid:0};
   GXValidFnc[149]={ id: 149, fld:"BTNCHECKCOMORBIDITY",grid:0};
   GXValidFnc[150]={ id: 150, fld:"",grid:0};
   GXValidFnc[151]={ id: 151, fld:"CELL_CHECKDEATH",grid:0};
   GXValidFnc[152]={ id: 152, fld:"BTNCHECKDEATH",grid:0};
   GXValidFnc[153]={ id: 153, fld:"",grid:0};
   GXValidFnc[154]={ id: 154, fld:"CELL_CHECKVITAL",grid:0};
   GXValidFnc[155]={ id: 155, fld:"BTNCHECKVITAL",grid:0};
   GXValidFnc[156]={ id: 156, fld:"",grid:0};
   GXValidFnc[157]={ id: 157, fld:"CELL_BR_DIAGNOSIS",grid:0};
   GXValidFnc[158]={ id: 158, fld:"BTNBR_DIAGNOSIS",grid:0};
   GXValidFnc[159]={ id: 159, fld:"",grid:0};
   GXValidFnc[160]={ id: 160, fld:"CELL_BR_LAB",grid:0};
   GXValidFnc[161]={ id: 161, fld:"BTNBR_LAB",grid:0};
   GXValidFnc[162]={ id: 162, fld:"",grid:0};
   GXValidFnc[163]={ id: 163, fld:"CELL_BR_MEDICATION",grid:0};
   GXValidFnc[164]={ id: 164, fld:"BTNBR_MEDICATION",grid:0};
   GXValidFnc[165]={ id: 165, fld:"",grid:0};
   GXValidFnc[166]={ id: 166, fld:"CELL_BR_SCHEME",grid:0};
   GXValidFnc[167]={ id: 167, fld:"BTNBR_SCHEME",grid:0};
   GXValidFnc[168]={ id: 168, fld:"",grid:0};
   GXValidFnc[169]={ id: 169, fld:"CELL_BR_PROCEDURE",grid:0};
   GXValidFnc[170]={ id: 170, fld:"BTNBR_PROCEDURE",grid:0};
   GXValidFnc[171]={ id: 171, fld:"",grid:0};
   GXValidFnc[172]={ id: 172, fld:"CELL_BR_MEDICALIMAGING",grid:0};
   GXValidFnc[173]={ id: 173, fld:"BTNBR_MEDICALIMAGING",grid:0};
   GXValidFnc[174]={ id: 174, fld:"",grid:0};
   GXValidFnc[175]={ id: 175, fld:"CELL_BR_PATHOLOGY",grid:0};
   GXValidFnc[176]={ id: 176, fld:"BTNBR_PATHOLOGY",grid:0};
   GXValidFnc[177]={ id: 177, fld:"",grid:0};
   GXValidFnc[178]={ id: 178, fld:"",grid:0};
   GXValidFnc[179]={ id: 179, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[180]={ id: 180, fld:"TABLEDVELOP_CONFIRMPANEL_CHECK",grid:0};
   GXValidFnc[185]={ id: 185, fld:"TABLEDVELOP_CONFIRMPANEL_CHECKR",grid:0};
   GXValidFnc[190]={ id: 190, fld:"TABLEDVELOP_CONFIRMPANEL_APPROVERIGHT",grid:0};
   GXValidFnc[195]={ id: 195, fld:"TABLEDVELOP_CONFIRMPANEL_APPROVEWRONG",grid:0};
   GXValidFnc[200]={ id: 200, fld:"TABLEDVELOP_CONFIRMPANEL_EDIT",grid:0};
   this.AV10BR_EncounterID = 0 ;
   this.AV8TabCode = "" ;
   this.A19BR_EncounterID = 0 ;
   this.AV16BCBR_Encounter = {BR_EncounterID:0,BR_Encounter_EncID:0,BR_Encounter_Department:"",BR_Encounter_Department_Code:"",BR_Encounter_Departmentadm:"",BR_Encounter_Departmentadm_Code:"",BR_Encounter_Departmentdisch:"",BR_Encounter_Departmentdisch_Code:"",BR_Encounter_ENCType:"",BR_Encounter_ENCType_Code:"",BR_Encounter_AdmitDate:gx.date.nullDate(),BR_Encounter_AdmitSource:"",BR_Encounter_AdmitSource_Code:"",BR_Encounter_DischargeDate:gx.date.nullDate(),BR_Encounter_DischargeStatus:"",BR_Encounter_DischargeStatus_Code:"",BR_Encounter_Insurance:"",BR_Encounter_Insurance_Code:"",BR_Encounter_Status:0,BR_Information_ID:0,BR_Information_PatientNo:"",BAS_TenantTenantCode:"",BR_Encounter_CrtDate:gx.date.nullDate(),BR_Encounter_UpdDate:gx.date.nullDate(),BR_Encounter_CrtUser:"",BR_Encounter_CrtDisplayName:"",BR_Encounter_UpdUser:"",BR_Encounter_IsDLT:false,BR_Encounter_SubmitUser:"",BR_Encounter_Reason:"",BR_Encounter_SubmitDate:gx.date.nullDate(),BR_Encounter_RecheckUser:"",BR_Encounter_FReason:"",BR_Encounter_RecheckDate:gx.date.nullDate(),BR_Encounter_Approver:"",BR_Encounter_ApproveDate:gx.date.nullDate(),BR_Encounter_IsRandApprove:false,BR_Encounter_IsRandApprover:"",BR_Encounter_IsRandNoApprover:"",BR_Encounter_IsRandApproveDate:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate:gx.date.nullDate(),BR_Encounter_IsRandRecheck:false,BR_Encounter_IsRandRecheckr:"",BR_Encounter_IsRandNoRecheckr:"",BR_Encounter_IsRandRecheckDate:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate:gx.date.nullDate(),BR_Encounter_IsUpdate:false,BR_Encounter_Datasource:0,EncounterIDEncrypt:"",Mode:"",Initialized:0,BR_EncounterID_Z:0,BR_Encounter_EncID_Z:0,BR_Encounter_Department_Z:"",BR_Encounter_Department_Code_Z:"",BR_Encounter_Departmentadm_Z:"",BR_Encounter_Departmentadm_Code_Z:"",BR_Encounter_Departmentdisch_Z:"",BR_Encounter_Departmentdisch_Code_Z:"",BR_Encounter_ENCType_Z:"",BR_Encounter_ENCType_Code_Z:"",BR_Encounter_AdmitDate_Z:gx.date.nullDate(),BR_Encounter_AdmitSource_Z:"",BR_Encounter_AdmitSource_Code_Z:"",BR_Encounter_DischargeDate_Z:gx.date.nullDate(),BR_Encounter_DischargeStatus_Z:"",BR_Encounter_DischargeStatus_Code_Z:"",BR_Encounter_Insurance_Z:"",BR_Encounter_Insurance_Code_Z:"",BR_Encounter_Status_Z:0,BR_Information_ID_Z:0,BR_Information_PatientNo_Z:"",BAS_TenantTenantCode_Z:"",BR_Encounter_CrtDate_Z:gx.date.nullDate(),BR_Encounter_UpdDate_Z:gx.date.nullDate(),BR_Encounter_CrtUser_Z:"",BR_Encounter_CrtDisplayName_Z:"",BR_Encounter_UpdUser_Z:"",BR_Encounter_IsDLT_Z:false,BR_Encounter_SubmitUser_Z:"",BR_Encounter_Reason_Z:"",BR_Encounter_SubmitDate_Z:gx.date.nullDate(),BR_Encounter_RecheckUser_Z:"",BR_Encounter_FReason_Z:"",BR_Encounter_RecheckDate_Z:gx.date.nullDate(),BR_Encounter_Approver_Z:"",BR_Encounter_ApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandApprove_Z:false,BR_Encounter_IsRandApprover_Z:"",BR_Encounter_IsRandNoApprover_Z:"",BR_Encounter_IsRandApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoApproveDate_Z:gx.date.nullDate(),BR_Encounter_IsRandRecheck_Z:false,BR_Encounter_IsRandRecheckr_Z:"",BR_Encounter_IsRandNoRecheckr_Z:"",BR_Encounter_IsRandRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsRandNoRecheckDate_Z:gx.date.nullDate(),BR_Encounter_IsUpdate_Z:false,BR_Encounter_Datasource_Z:0,EncounterIDEncrypt_Z:""} ;
   this.AV27tvflag = "" ;
   this.AV6WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV25tPageReturn = "" ;
   this.AV11LoadAllTabs = false ;
   this.AV12SelectedTabCode = "" ;
   this.Events = {"e173s2_client": ["DVELOP_CONFIRMPANEL_CHECK.CLOSE", true] ,"e183s2_client": ["DVELOP_CONFIRMPANEL_CHECKR.CLOSE", true] ,"e193s2_client": ["DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE", true] ,"e203s2_client": ["DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE", true] ,"e213s2_client": ["DVELOP_CONFIRMPANEL_EDIT.CLOSE", true] ,"e253s2_client": ["'DORETURN'", true] ,"e163s2_client": ["TABS.TABCHANGED", true] ,"e263s2_client": ["'GENERAL'", true] ,"e273s2_client": ["'CHECKDEMOGRAPHICS'", true] ,"e283s2_client": ["'CHECKBEHAVIOR'", true] ,"e293s2_client": ["'CHECKCOMORBIDITY'", true] ,"e303s2_client": ["'CHECKDEATH'", true] ,"e313s2_client": ["'CHECKVITAL'", true] ,"e323s2_client": ["'BR_DIAGNOSIS'", true] ,"e333s2_client": ["'BR_LAB'", true] ,"e343s2_client": ["'BR_MEDICATION'", true] ,"e353s2_client": ["'BR_SCHEME'", true] ,"e363s2_client": ["'BR_PROCEDURE'", true] ,"e373s2_client": ["'BR_MEDICALIMAGING'", true] ,"e383s2_client": ["'BR_PATHOLOGY'", true] ,"e393s2_client": ["'DOREFUSE'", true] ,"e403s2_client": ["ENTER", true] ,"e413s2_client": ["CANCEL", true] ,"e113s1_client": ["'DOCHECK'", false] ,"e123s1_client": ["'DOCHECKR'", false] ,"e133s1_client": ["'DOAPPROVERIGHT'", false] ,"e143s1_client": ["'DOAPPROVEWRONG'", false] ,"e153s1_client": ["'DOEDIT'", false]};
   this.EvtParms["REFRESH"] = [[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV27tvflag',fld:'vTVFLAG',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{ctrl:'BTNEDIT',prop:'Visible'},{ctrl:'BTNCHECK',prop:'Visible'},{ctrl:'BTNCHECKR',prop:'Visible'},{ctrl:'BTNAPPROVERIGHT',prop:'Visible'},{ctrl:'BTNAPPROVEWRONG',prop:'Visible'}]];
   this.EvtParms["START"] = [[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}],[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{ctrl:'FORM',prop:'Caption'},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["LOAD"] = [[],[]];
   this.EvtParms["'DOCHECK'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_CHECK.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_CHECKContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_CHECK',prop:'Result'},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DOCHECKR'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_CHECKR.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_CHECKRContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_CHECKR',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]];
   this.EvtParms["'DOAPPROVERIGHT'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_APPROVERIGHTContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_APPROVERIGHT',prop:'Result'},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DOAPPROVEWRONG'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_APPROVEWRONGContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_APPROVEWRONG',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]];
   this.EvtParms["'DOEDIT'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_EDIT.CLOSE"] = [[{av:'this.DVELOP_CONFIRMPANEL_EDITContainer.Result',ctrl:'DVELOP_CONFIRMPANEL_EDIT',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''}],[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]];
   this.EvtParms["'DORETURN'"] = [[{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}],[]];
   this.EvtParms["TABS.TABCHANGED"] = [[{av:'this.TABSContainer.ActivePageControlName',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'GENERAL'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'CHECKDEMOGRAPHICS'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'CHECKBEHAVIOR'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'CHECKCOMORBIDITY'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'CHECKDEATH'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'CHECKVITAL'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_DIAGNOSIS'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_LAB'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_MEDICATION'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_SCHEME'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_PROCEDURE'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_MEDICALIMAGING'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'BR_PATHOLOGY'"] = [[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'gx.fn.getCtrlProperty("CELL_GENERAL","Visible")',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'gx.fn.getCtrlProperty("TXTTABTITLE","Caption")',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEMOGRAPHICS","Visible")',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKBEHAVIOR","Visible")',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKCOMORBIDITY","Visible")',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKDEATH","Visible")',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'gx.fn.getCtrlProperty("CELL_CHECKVITAL","Visible")',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_DIAGNOSIS","Visible")',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_LAB","Visible")',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICATION","Visible")',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_SCHEME","Visible")',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PROCEDURE","Visible")',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_MEDICALIMAGING","Visible")',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'gx.fn.getCtrlProperty("CELL_BR_PATHOLOGY","Visible")',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]];
   this.EvtParms["'DOREFUSE'"] = [[{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]];
   this.setVCMap("AV16BCBR_Encounter", "vBCBR_ENCOUNTER", 0, "BR_Encounter", 0, 0);
   this.setVCMap("AV27tvflag", "vTVFLAG", 0, "svchar", 40, 0);
   this.setVCMap("AV6WWPContext", "vWWPCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("AV25tPageReturn", "vTPAGERETURN", 0, "svchar", 100, 0);
   this.setVCMap("AV10BR_EncounterID", "vBR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV11LoadAllTabs", "vLOADALLTABS", 0, "boolean", 4, 0);
   this.setVCMap("AV12SelectedTabCode", "vSELECTEDTABCODE", 0, "char", 50, 0);
   this.setVCMap("AV8TabCode", "vTABCODE", 0, "char", 50, 0);
   this.Initialize( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0038" , lvl: 1 });
   this.setComponent({id: "CHECKDEMOGRAPHICSWC" ,GXClass: null , Prefix: "W0046" , lvl: 1 });
   this.setComponent({id: "CHECKBEHAVIORWC" ,GXClass: null , Prefix: "W0054" , lvl: 1 });
   this.setComponent({id: "CHECKCOMORBIDITYWC" ,GXClass: null , Prefix: "W0062" , lvl: 1 });
   this.setComponent({id: "CHECKDEATHWC" ,GXClass: null , Prefix: "W0070" , lvl: 1 });
   this.setComponent({id: "CHECKVITALWC" ,GXClass: null , Prefix: "W0078" , lvl: 1 });
   this.setComponent({id: "BR_DIAGNOSISWC" ,GXClass: null , Prefix: "W0086" , lvl: 1 });
   this.setComponent({id: "BR_LABWC" ,GXClass: null , Prefix: "W0094" , lvl: 1 });
   this.setComponent({id: "BR_MEDICATIONWC" ,GXClass: null , Prefix: "W0102" , lvl: 1 });
   this.setComponent({id: "BR_SCHEMEWC" ,GXClass: null , Prefix: "W0110" , lvl: 1 });
   this.setComponent({id: "BR_PROCEDUREWC" ,GXClass: null , Prefix: "W0118" , lvl: 1 });
   this.setComponent({id: "BR_MEDICALIMAGINGWC" ,GXClass: null , Prefix: "W0126" , lvl: 1 });
   this.setComponent({id: "BR_PATHOLOGYWC" ,GXClass: null , Prefix: "W0134" , lvl: 1 });
});
gx.createParentObj(br_encountercheck);
