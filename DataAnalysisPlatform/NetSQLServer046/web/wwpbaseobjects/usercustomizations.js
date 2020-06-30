/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:55:34.22
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.usercustomizations', false, function () {
   this.ServerClass =  "wwpbaseobjects.usercustomizations" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Usercustomizationsid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("USERCUSTOMIZATIONSID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Usercustomizationskey=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Usercustomizationskey",["gx.O.A16UserCustomizationsId", "gx.O.A17UserCustomizationsKey", "gx.O.A18UserCustomizationsValue"],["A18UserCustomizationsValue", "Gx_mode", "Z16UserCustomizationsId", "Z17UserCustomizationsKey", "Z18UserCustomizationsValue", ["BTN_DELETE","Enabled"], ["BTN_ENTER","Enabled"]]);
      return true;
   }
   this.e11078_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e12078_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47];
   this.GXLastCtrlId =47;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"TABLEMAIN",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TITLE", format:0,grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"BTN_FIRST",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"BTN_PREVIOUS",grid:0};
   GXValidFnc[15]={ id: 15, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"BTN_NEXT",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"BTN_LAST",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"BTN_SELECT",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id:28 ,lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usercustomizationsid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERCUSTOMIZATIONSID",gxz:"Z16UserCustomizationsId",gxold:"O16UserCustomizationsId",gxvar:"A16UserCustomizationsId",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A16UserCustomizationsId=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z16UserCustomizationsId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("USERCUSTOMIZATIONSID",gx.O.A16UserCustomizationsId,0)},c2v:function(){if(this.val()!==undefined)gx.O.A16UserCustomizationsId=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("USERCUSTOMIZATIONSID",',')},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"svchar",len:200,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:this.Valid_Usercustomizationskey,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERCUSTOMIZATIONSKEY",gxz:"Z17UserCustomizationsKey",gxold:"O17UserCustomizationsKey",gxvar:"A17UserCustomizationsKey",ucs:[],op:[38],ip:[38,33,28],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A17UserCustomizationsKey=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z17UserCustomizationsKey=Value},v2c:function(){gx.fn.setControlValue("USERCUSTOMIZATIONSKEY",gx.O.A17UserCustomizationsKey,0)},c2v:function(){if(this.val()!==undefined)gx.O.A17UserCustomizationsKey=this.val()},val:function(){return gx.fn.getControlValue("USERCUSTOMIZATIONSKEY")},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"USERCUSTOMIZATIONSVALUE",gxz:"Z18UserCustomizationsValue",gxold:"O18UserCustomizationsValue",gxvar:"A18UserCustomizationsValue",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A18UserCustomizationsValue=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z18UserCustomizationsValue=Value},v2c:function(){gx.fn.setControlValue("USERCUSTOMIZATIONSVALUE",gx.O.A18UserCustomizationsValue,0)},c2v:function(){if(this.val()!==undefined)gx.O.A18UserCustomizationsValue=this.val()},val:function(){return gx.fn.getControlValue("USERCUSTOMIZATIONSVALUE")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"BTN_ENTER",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTN_CANCEL",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"BTN_DELETE",grid:0};
   this.A16UserCustomizationsId = 0 ;
   this.Z16UserCustomizationsId = 0 ;
   this.O16UserCustomizationsId = 0 ;
   this.A17UserCustomizationsKey = "" ;
   this.Z17UserCustomizationsKey = "" ;
   this.O17UserCustomizationsKey = "" ;
   this.A18UserCustomizationsValue = "" ;
   this.Z18UserCustomizationsValue = "" ;
   this.O18UserCustomizationsValue = "" ;
   this.A16UserCustomizationsId = 0 ;
   this.A17UserCustomizationsKey = "" ;
   this.A18UserCustomizationsValue = "" ;
   this.Events = {"e11078_client": ["ENTER", true] ,"e12078_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true}],[]];
   this.EvtParms["REFRESH"] = [[],[]];
   this.EnterCtrl = ["BTN_ENTER"];
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.usercustomizations);
