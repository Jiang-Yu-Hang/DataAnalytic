/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:7:15.89
*/
gx.evt.autoSkip = false;
gx.define('webpanel1', false, function () {
   this.ServerClass =  "webpanel1" ;
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
   this.e11a41_client=function()
   {
      this.clearMessages();
      this.DVELOP_CONFIRMPANEL_BTNTESTContainer.Confirm() ;
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e14a41_client=function()
   {
      this.clearMessages();
      this.addMessage("5555");
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e15a42_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e16a42_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,19];
   this.GXLastCtrlId =19;
   this.DVELOP_CONFIRMPANEL_BTNTESTContainer = gx.uc.getNew(this, 22, 0, "BootstrapConfirmPanel", "DVELOP_CONFIRMPANEL_BTNTESTContainer", "Dvelop_confirmpanel_btntest", "DVELOP_CONFIRMPANEL_BTNTEST");
   var DVELOP_CONFIRMPANEL_BTNTESTContainer = this.DVELOP_CONFIRMPANEL_BTNTESTContainer;
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Class", "Class", "", "char");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Width", "Width", "100", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Height", "Height", "100", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Title", "Title", "", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("ConfirmationText", "Confirmationtext", "纭畾锛?, "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("YesButtonCaption", "Yesbuttoncaption", "WWP_ConfirmTextYes", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("NoButtonCaption", "Nobuttoncaption", "WWP_ConfirmTextNo", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("CancelButtonCaption", "Cancelbuttoncaption", "WWP_ConfirmTextCancel", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("YesButtonPosition", "Yesbuttonposition", "left", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("ConfirmType", "Confirmtype", "1", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Result", "Result", "", "char");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("TextType", "Texttype", "1", "str");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setProp("Visible", "Visible", true, "bool");
   DVELOP_CONFIRMPANEL_BTNTESTContainer.setC2ShowFunction(function(UC) { UC.show(); });
   DVELOP_CONFIRMPANEL_BTNTESTContainer.addEventHandler("Close", this.e14a41_client);
   this.setUserControl(DVELOP_CONFIRMPANEL_BTNTESTContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLECONTENT",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"BTNTEST",grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[19]={ id: 19, fld:"TABLEDVELOP_CONFIRMPANEL_BTNTEST",grid:0};
   this.Events = {"e15a42_client": ["ENTER", true] ,"e16a42_client": ["CANCEL", true] ,"e11a41_client": ["'DOTEST'", false] ,"e14a41_client": ["DVELOP_CONFIRMPANEL_BTNTEST.CLOSE", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[],[]];
   this.EvtParms["'DOTEST'"] = [[],[]];
   this.EvtParms["DVELOP_CONFIRMPANEL_BTNTEST.CLOSE"] = [[],[]];
   this.Initialize( );
});
gx.createParentObj(webpanel1);
