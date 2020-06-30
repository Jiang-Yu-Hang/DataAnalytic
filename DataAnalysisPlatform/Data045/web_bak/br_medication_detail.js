/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:42.41
*/
gx.evt.autoSkip = false;
gx.define('br_medication_detail', false, function () {
   this.ServerClass =  "br_medication_detail" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_Medication_DetailID=gx.fn.getIntegerValue("vBR_MEDICATION_DETAILID",',') ;
      this.AV13Insert_BR_Medication_SchemeID=gx.fn.getIntegerValue("vINSERT_BR_MEDICATION_SCHEMEID",',') ;
      this.AV15Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_medication_detailid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_DETAILID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_medication_drug_name=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATION_DRUG_NAME");
         this.AnyError  = 0;
         if ( ((''==this.A310BR_Medication_Drug_Name)) )
         {
            try {
               gxballoon.setError("鑽墿鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_medication_schemeid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_medication_schemeid",["gx.num.urlDecimal(gx.O.A296BR_Medication_SchemeID,\',\',\'.\')"],[]);
      return true;
   }
   this.e120u2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130u31_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140u31_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47];
   this.GXLastCtrlId =47;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鑽墿娌荤枟鑽墿璇︽儏", "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_drug_name,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NAME",gxz:"Z310BR_Medication_Drug_Name",gxold:"O310BR_Medication_Drug_Name",gxvar:"A310BR_Medication_Drug_Name",ucs:[],op:[25],ip:[25],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A310BR_Medication_Drug_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z310BR_Medication_Drug_Name=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_DRUG_NAME",gx.O.A310BR_Medication_Drug_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A310BR_Medication_Drug_Name=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_DRUG_NAME")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_NUM",gxz:"Z311BR_Medication_Drug_Num",gxold:"O311BR_Medication_Drug_Num",gxvar:"A311BR_Medication_Drug_Num",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z311BR_Medication_Drug_Num=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_DRUG_NUM",gx.O.A311BR_Medication_Drug_Num,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A311BR_Medication_Drug_Num=this.val()},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_DRUG_NUM",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 29 , function() {
   });
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id:33 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DRUG_UNIT",gxz:"Z312BR_Medication_Drug_Unit",gxold:"O312BR_Medication_Drug_Unit",gxvar:"A312BR_Medication_Drug_Unit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A312BR_Medication_Drug_Unit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z312BR_Medication_Drug_Unit=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_DRUG_UNIT",gx.O.A312BR_Medication_Drug_Unit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A312BR_Medication_Drug_Unit=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_DRUG_UNIT")},nac:gx.falseFn};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_detailid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_DETAILID",gxz:"Z301BR_Medication_DetailID",gxold:"O301BR_Medication_DetailID",gxvar:"A301BR_Medication_DetailID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z301BR_Medication_DetailID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_DETAILID",gx.O.A301BR_Medication_DetailID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A301BR_Medication_DetailID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_DETAILID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 46 , function() {
   });
   GXValidFnc[47]={ id:47 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_medication_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_SCHEMEID",gxz:"Z296BR_Medication_SchemeID",gxold:"O296BR_Medication_SchemeID",gxvar:"A296BR_Medication_SchemeID",ucs:[],op:[],ip:[47],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z296BR_Medication_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_SCHEMEID",gx.O.A296BR_Medication_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A296BR_Medication_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATION_SCHEMEID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_Medication_SchemeID))}};
   this.declareDomainHdlr( 47 , function() {
   });
   this.A310BR_Medication_Drug_Name = "" ;
   this.Z310BR_Medication_Drug_Name = "" ;
   this.O310BR_Medication_Drug_Name = "" ;
   this.A311BR_Medication_Drug_Num = 0 ;
   this.Z311BR_Medication_Drug_Num = 0 ;
   this.O311BR_Medication_Drug_Num = 0 ;
   this.A312BR_Medication_Drug_Unit = "" ;
   this.Z312BR_Medication_Drug_Unit = "" ;
   this.O312BR_Medication_Drug_Unit = "" ;
   this.A301BR_Medication_DetailID = 0 ;
   this.Z301BR_Medication_DetailID = 0 ;
   this.O301BR_Medication_DetailID = 0 ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.Z296BR_Medication_SchemeID = 0 ;
   this.O296BR_Medication_SchemeID = 0 ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV15Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV16GXV1 = 0 ;
   this.AV13Insert_BR_Medication_SchemeID = 0 ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_Medication_DetailID = 0 ;
   this.AV12WebSession = {} ;
   this.A301BR_Medication_DetailID = 0 ;
   this.A296BR_Medication_SchemeID = 0 ;
   this.A310BR_Medication_Drug_Name = "" ;
   this.A311BR_Medication_Drug_Num = 0 ;
   this.A312BR_Medication_Drug_Unit = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120u2_client": ["AFTER TRN", true] ,"e130u31_client": ["ENTER", true] ,"e140u31_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_DetailID',fld:'vBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_DetailID',fld:'vBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_Medication_SchemeID',fld:'vINSERT_BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV15Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV16GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_Medication_SchemeID',fld:'vINSERT_BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_DETAILID","Visible")',ctrl:'BR_MEDICATION_DETAILID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_MEDICATION_SCHEMEID","Visible")',ctrl:'BR_MEDICATION_SCHEMEID',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_Medication_DetailID", "vBR_MEDICATION_DETAILID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_Medication_SchemeID", "vINSERT_BR_MEDICATION_SCHEMEID", 0, "int", 18, 0);
   this.setVCMap("AV15Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_medication_detail);
