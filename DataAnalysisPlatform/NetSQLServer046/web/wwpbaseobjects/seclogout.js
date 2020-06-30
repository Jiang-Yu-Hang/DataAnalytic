/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:7.3
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.seclogout', false, function () {
   this.ServerClass =  "wwpbaseobjects.seclogout" ;
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
   this.e127i2_client=function()
   {
      return this.executeServerEvent("TOLOGINAGAIN.CLICK", true, null, false, true);
   };
   this.e147i2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e157i2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,18];
   this.GXLastCtrlId =18;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TABLECONTENT",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"UNAUTHORIZEDACCESS", format:0,grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"UNNAMEDTABLE1",grid:0};
   GXValidFnc[18]={ id: 18, fld:"TOLOGINAGAIN", format:0,grid:0,evt:"e127i2_client"};
   this.Events = {"e127i2_client": ["TOLOGINAGAIN.CLICK", true] ,"e147i2_client": ["ENTER", true] ,"e157i2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[],[{ctrl:'FORM',prop:'Headerrawhtml'}]];
   this.EvtParms["TOLOGINAGAIN.CLICK"] = [[],[]];
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.seclogout);
