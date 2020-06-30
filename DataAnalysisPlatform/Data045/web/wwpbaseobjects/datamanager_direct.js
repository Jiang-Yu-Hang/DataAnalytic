/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:16:9.71
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.datamanager_direct', false, function () {
   this.ServerClass =  "wwpbaseobjects.datamanager_direct" ;
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
   this.e137h2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e147h2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2];
   this.GXLastCtrlId =2;
   GXValidFnc[2]={ id: 2, fld:"TEXTBLOCK1", format:0,grid:0};
   this.Events = {"e137h2_client": ["ENTER", true] ,"e147h2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[],[]];
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.datamanager_direct);
