/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:58:4.29
*/
gx.evt.autoSkip = false;
gx.define('br_encounterreason', false, function () {
   this.ServerClass =  "br_encounterreason" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV16BR_Encounter_ID=gx.fn.getIntegerValue("vBR_ENCOUNTER_ID",',') ;
      this.AV15Insert_BR_EncounterID=gx.fn.getIntegerValue("vINSERT_BR_ENCOUNTERID",',') ;
      this.AV17Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV10TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_encounter_id=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTER_ID");
         this.AnyError  = 0;
         if ( ((0==this.A347BR_Encounter_ID)) )
         {
            try {
               gxballoon.setError("涓婚敭鏄繀椤诲～鍐欑殑銆?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_encounterreason_israndnoapprovedate=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE");
         this.AnyError  = 0;
         if ( ! ( (new gx.date.gxdate('').compare(this.A341BR_EncounterReason_IsRandNoApproveDate)==0) || new gx.date.gxdate( this.A341BR_EncounterReason_IsRandNoApproveDate ).compare( gx.date.ymdhmstot( 1753, 01, 01, 00, 00, 00) ) >= 0 ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷瓒呯晫");
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_encounterid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_encounterid",["gx.num.urlDecimal(gx.O.A19BR_EncounterID,\',\',\'.\')"],[]);
      return true;
   }
   this.Valid_Br_encounterreason_status=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_ENCOUNTERREASON_STATUS");
         this.AnyError  = 0;
         if ( ! ( ( this.A343BR_EncounterReason_Status == 1 ) || ( this.A343BR_EncounterReason_Status == 2 ) || ((0==this.A343BR_EncounterReason_Status)) ) )
         {
            try {
               gxballoon.setError("鍩燂拷锟斤拷锟斤拷锟斤拷锟斤拷锟斤拷锟借秴鐣?);
               this.AnyError = gx.num.trunc( 1 ,0) ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e12142_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e131441_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e141441_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51];
   this.GXLastCtrlId =51;
   this.DVPANEL_TABLEATTRIBUTESContainer = gx.uc.getNew(this, 16, 0, "BootstrapPanel", "DVPANEL_TABLEATTRIBUTESContainer", "Dvpanel_tableattributes", "DVPANEL_TABLEATTRIBUTES");
   var DVPANEL_TABLEATTRIBUTESContainer = this.DVPANEL_TABLEATTRIBUTESContainer;
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Class", "Class", "", "char");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Enabled", "Enabled", true, "boolean");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Width", "Width", "100%", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Height", "Height", "100", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoWidth", "Autowidth", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoHeight", "Autoheight", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Cls", "Cls", "PanelCard_BaseColor", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowHeader", "Showheader", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鍩虹淇℃伅", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsible", "Collapsible", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Collapsed", "Collapsed", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("ShowCollapseIcon", "Showcollapseicon", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("IconPosition", "Iconposition", "left", "str");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("AutoScroll", "Autoscroll", false, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Visible", "Visible", true, "bool");
   DVPANEL_TABLEATTRIBUTESContainer.setC2ShowFunction(function(UC) { UC.show(); });
   this.setUserControl(DVPANEL_TABLEATTRIBUTESContainer);
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
   GXValidFnc[15]={ id: 15, fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[18]={ id: 18, fld:"LAYOUT_TABLEATTRIBUTES",grid:0};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"TABLEATTRIBUTES",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:15,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_encounter_id,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTER_ID",gxz:"Z347BR_Encounter_ID",gxold:"O347BR_Encounter_ID",gxvar:"A347BR_Encounter_ID",ucs:[],op:[25],ip:[25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A347BR_Encounter_ID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z347BR_Encounter_ID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTER_ID",gx.O.A347BR_Encounter_ID,0)},c2v:function(){if(this.val()!==undefined)gx.O.A347BR_Encounter_ID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTER_ID",',')},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"svchar",len:300,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_REASON",gxz:"Z340BR_EncounterReason_Reason",gxold:"O340BR_EncounterReason_Reason",gxvar:"A340BR_EncounterReason_Reason",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A340BR_EncounterReason_Reason=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z340BR_EncounterReason_Reason=Value},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERREASON_REASON",gx.O.A340BR_EncounterReason_Reason,0)},c2v:function(){if(this.val()!==undefined)gx.O.A340BR_EncounterReason_Reason=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTERREASON_REASON")},nac:gx.falseFn};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"dtime",len:10,dec:8,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterreason_israndnoapprovedate,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",gxz:"Z341BR_EncounterReason_IsRandNoApproveDate",gxold:"O341BR_EncounterReason_IsRandNoApproveDate",gxvar:"A341BR_EncounterReason_IsRandNoApproveDate",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[35],ip:[35],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE",gx.O.A341BR_EncounterReason_IsRandNoApproveDate,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A341BR_EncounterReason_IsRandNoApproveDate=gx.fn.toDatetimeValue(this.val())},val:function(){return gx.fn.getDateTimeValue("BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE")},nac:gx.falseFn};
   this.declareDomainHdlr( 35 , function() {
   });
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERID",gxz:"Z19BR_EncounterID",gxold:"O19BR_EncounterID",gxvar:"A19BR_EncounterID",ucs:[],op:[],ip:[48],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z19BR_EncounterID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERID",gx.O.A19BR_EncounterID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A19BR_EncounterID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV15Insert_BR_EncounterID))}};
   this.declareDomainHdlr( 48 , function() {
   });
   GXValidFnc[49]={ id:49 ,lvl:0,type:"boolean",len:4,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDAPPROVE",gxz:"Z342BR_EncounterReason_IsRandApprove",gxold:"O342BR_EncounterReason_IsRandApprove",gxvar:"A342BR_EncounterReason_IsRandApprove",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(Value)},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVE",gx.O.A342BR_EncounterReason_IsRandApprove,0)},c2v:function(){if(this.val()!==undefined)gx.O.A342BR_EncounterReason_IsRandApprove=gx.lang.booleanValue(this.val())},val:function(){return gx.fn.getControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVE")},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_encounterreason_status,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_STATUS",gxz:"Z343BR_EncounterReason_Status",gxold:"O343BR_EncounterReason_Status",gxvar:"A343BR_EncounterReason_Status",ucs:[],op:[50],ip:[50],
						nacdep:[],ctrltype:"combo",v2v:function(Value){if(Value!==undefined)gx.O.A343BR_EncounterReason_Status=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z343BR_EncounterReason_Status=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("BR_ENCOUNTERREASON_STATUS",gx.O.A343BR_EncounterReason_Status);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A343BR_EncounterReason_Status=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_ENCOUNTERREASON_STATUS",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 50 , function() {
   });
   GXValidFnc[51]={ id:51 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_ENCOUNTERREASON_ISRANDAPPROVER",gxz:"Z344BR_EncounterReason_IsRandApprover",gxold:"O344BR_EncounterReason_IsRandApprover",gxvar:"A344BR_EncounterReason_IsRandApprover",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A344BR_EncounterReason_IsRandApprover=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z344BR_EncounterReason_IsRandApprover=Value},v2c:function(){gx.fn.setControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVER",gx.O.A344BR_EncounterReason_IsRandApprover,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A344BR_EncounterReason_IsRandApprover=this.val()},val:function(){return gx.fn.getControlValue("BR_ENCOUNTERREASON_ISRANDAPPROVER")},nac:gx.falseFn};
   this.declareDomainHdlr( 51 , function() {
   });
   this.A347BR_Encounter_ID = 0 ;
   this.Z347BR_Encounter_ID = 0 ;
   this.O347BR_Encounter_ID = 0 ;
   this.A340BR_EncounterReason_Reason = "" ;
   this.Z340BR_EncounterReason_Reason = "" ;
   this.O340BR_EncounterReason_Reason = "" ;
   this.A341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.Z341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.O341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.A19BR_EncounterID = 0 ;
   this.Z19BR_EncounterID = 0 ;
   this.O19BR_EncounterID = 0 ;
   this.A342BR_EncounterReason_IsRandApprove = false ;
   this.Z342BR_EncounterReason_IsRandApprove = false ;
   this.O342BR_EncounterReason_IsRandApprove = false ;
   this.A343BR_EncounterReason_Status = 0 ;
   this.Z343BR_EncounterReason_Status = 0 ;
   this.O343BR_EncounterReason_Status = 0 ;
   this.A344BR_EncounterReason_IsRandApprover = "" ;
   this.Z344BR_EncounterReason_IsRandApprover = "" ;
   this.O344BR_EncounterReason_IsRandApprover = "" ;
   this.AV7WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV8IsAuthorized = false ;
   this.AV17Pgmname = "" ;
   this.AV10TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV18GXV1 = 0 ;
   this.AV15Insert_BR_EncounterID = 0 ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV16BR_Encounter_ID = 0 ;
   this.AV11WebSession = {} ;
   this.A347BR_Encounter_ID = 0 ;
   this.A19BR_EncounterID = 0 ;
   this.A340BR_EncounterReason_Reason = "" ;
   this.A341BR_EncounterReason_IsRandNoApproveDate = gx.date.nullDate() ;
   this.A342BR_EncounterReason_IsRandApprove = false ;
   this.A343BR_EncounterReason_Status = 0 ;
   this.A344BR_EncounterReason_IsRandApprover = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e12142_client": ["AFTER TRN", true] ,"e131441_client": ["ENTER", true] ,"e141441_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16BR_Encounter_ID',fld:'vBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16BR_Encounter_ID',fld:'vBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9',hsh:true},{av:'A347BR_Encounter_ID',fld:'BR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV15Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV17Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV7WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV8IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV18GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV15Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERID","Visible")',ctrl:'BR_ENCOUNTERID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVE","Visible")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Visible'},{ctrl:'BR_ENCOUNTERREASON_STATUS'},{av:'gx.fn.getCtrlProperty("BR_ENCOUNTERREASON_ISRANDAPPROVER","Visible")',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV16BR_Encounter_ID", "vBR_ENCOUNTER_ID", 0, "int", 15, 0);
   this.setVCMap("AV15Insert_BR_EncounterID", "vINSERT_BR_ENCOUNTERID", 0, "int", 18, 0);
   this.setVCMap("AV17Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV10TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_encounterreason);
