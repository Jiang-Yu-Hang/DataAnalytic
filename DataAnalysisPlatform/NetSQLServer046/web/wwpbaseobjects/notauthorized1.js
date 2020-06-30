/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:29.52
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.notauthorized1', false, function () {
   this.ServerClass =  "wwpbaseobjects.notauthorized1" ;
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
      this.GxObject=gx.fn.getControlValue("vGXOBJECT") ;
   };
   this.e11811_client=function()
   {
      this.clearMessages();
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e12811_client=function()
   {
      this.clearMessages();
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e13811_client=function()
   {
      this.clearMessages();
      this.refreshOutputs([]);
      return gx.$.Deferred().resolve();
   };
   this.e16812_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e17812_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37];
   this.GXLastCtrlId =37;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"NOTAUTHORIZEDIMAGE",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"ENGLISHWARN",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"FIRSTWARN", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"SECONDWARN", format:0,grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"CHINESEWARN",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"THIRDWARN", format:0,grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"FOURTHWARN", format:0,grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"BTNRETURNBACK",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"BTNINDEX",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"BTNLOGOUT",grid:0};
   this.GxObject = "" ;
   this.Events = {"e16812_client": ["ENTER", true] ,"e17812_client": ["CANCEL", true] ,"e11811_client": ["'DORETURNBACK'", false] ,"e12811_client": ["'DOINDEX'", false] ,"e13811_client": ["'DOLOGOUT'", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[],[]];
   this.EvtParms["'DORETURNBACK'"] = [[],[]];
   this.EvtParms["'DOINDEX'"] = [[],[]];
   this.EvtParms["'DOLOGOUT'"] = [[],[]];
   this.setVCMap("GxObject", "vGXOBJECT", 0, "svchar", 256, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.notauthorized1);
