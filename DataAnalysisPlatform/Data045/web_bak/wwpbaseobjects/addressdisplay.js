/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:39:7.52
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.addressdisplay', false, function () {
   this.ServerClass =  "wwpbaseobjects.addressdisplay" ;
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
      this.AV5Address=gx.fn.getControlValue("vADDRESS") ;
      this.AV6Geolocation=gx.fn.getControlValue("vGEOLOCATION") ;
   };
   this.e13072_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14072_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,5];
   this.GXLastCtrlId =5;
   GXValidFnc[2]={ id: 2, fld:"TABLEMAIN",grid:0};
   GXValidFnc[5]={ id: 5, fld:"UTEMBEDDEDPAGE",grid:0};
   this.AV5Address = "" ;
   this.AV6Geolocation = "" ;
   this.Events = {"e13072_client": ["ENTER", true] ,"e14072_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV5Address',fld:'vADDRESS',pic:'',hsh:true},{av:'AV6Geolocation',fld:'vGEOLOCATION',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV5Address',fld:'vADDRESS',pic:'',hsh:true},{av:'AV6Geolocation',fld:'vGEOLOCATION',pic:'',hsh:true},{av:'AV12Pgmname',fld:'vPGMNAME',pic:''}],[{ctrl:'GOOGLEMAPSEMBPAGE',prop:'Source'}]];
   this.setVCMap("AV5Address", "vADDRESS", 0, "svchar", 1000, 0);
   this.setVCMap("AV6Geolocation", "vGEOLOCATION", 0, "svchar", 200, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.addressdisplay);
