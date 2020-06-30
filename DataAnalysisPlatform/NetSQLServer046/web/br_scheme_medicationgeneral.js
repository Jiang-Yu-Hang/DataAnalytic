/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:53:58.34
*/
gx.evt.autoSkip = false;
gx.define('br_scheme_medicationgeneral', true, function (CmpContext) {
   this.ServerClass =  "br_scheme_medicationgeneral" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
   };
   this.Valid_Br_medicationid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_MEDICATIONID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_scheme_medicationid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEME_MEDICATIONID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_schemeid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_SCHEMEID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e136k2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e146k2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49];
   this.GXLastCtrlId =49;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLE",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"UNNAMEDTABLEBR_SCHEME_CHEM_REGIMENS",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"TEXTBLOCKBR_SCHEME_CHEM_REGIMENS", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_CHEM_REGIMENS",gxz:"Z328BR_Scheme_Chem_Regimens",gxold:"O328BR_Scheme_Chem_Regimens",gxvar:"A328BR_Scheme_Chem_Regimens",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z328BR_Scheme_Chem_Regimens=Value},v2c:function(){gx.fn.setControlValue("BR_SCHEME_CHEM_REGIMENS",gx.O.A328BR_Scheme_Chem_Regimens,0)},c2v:function(){if(this.val()!==undefined)gx.O.A328BR_Scheme_Chem_Regimens=this.val()},val:function(){return gx.fn.getControlValue("BR_SCHEME_CHEM_REGIMENS")},nac:gx.falseFn};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"UNNAMEDTABLEBR_MEDICATIONID",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TEXTBLOCKBR_MEDICATIONID", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATIONID",gxz:"Z119BR_MedicationID",gxold:"O119BR_MedicationID",gxvar:"A119BR_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z119BR_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICATIONID",gx.O.A119BR_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A119BR_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICATIONID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 26 , function() {
   });
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id:31 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXNAME",gxz:"Z121BR_Medication_RXName",gxold:"O121BR_Medication_RXName",gxvar:"A121BR_Medication_RXName",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A121BR_Medication_RXName=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z121BR_Medication_RXName=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXNAME",gx.O.A121BR_Medication_RXName,0)},c2v:function(){if(this.val()!==undefined)gx.O.A121BR_Medication_RXName=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXNAME")},nac:gx.falseFn};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id:35 ,lvl:0,type:"decimal",len:15,dec:5,sign:false,pic:"ZZZZZZZZZ.ZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXDOSE",gxz:"Z124BR_Medication_RXDose",gxold:"O124BR_Medication_RXDose",gxvar:"A124BR_Medication_RXDose",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){if(Value!==undefined)gx.O.Z124BR_Medication_RXDose=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("BR_MEDICATION_RXDOSE",gx.O.A124BR_Medication_RXDose,5,'.');if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A124BR_Medication_RXDose=this.val()},val:function(){return gx.fn.getDecimalValue("BR_MEDICATION_RXDOSE",',','.')},nac:gx.falseFn};
   this.declareDomainHdlr( 35 , function() {
   });
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"UNNAMEDTABLEBR_MEDICATION_RXUNIT",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"TEXTBLOCKBR_MEDICATION_RXUNIT", format:0,grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id:44 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICATION_RXUNIT",gxz:"Z125BR_Medication_RXUnit",gxold:"O125BR_Medication_RXUnit",gxvar:"A125BR_Medication_RXUnit",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A125BR_Medication_RXUnit=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z125BR_Medication_RXUnit=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICATION_RXUNIT",gx.O.A125BR_Medication_RXUnit,0)},c2v:function(){if(this.val()!==undefined)gx.O.A125BR_Medication_RXUnit=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICATION_RXUNIT")},nac:gx.falseFn};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[48]={ id:48 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_scheme_medicationid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEME_MEDICATIONID",gxz:"Z332BR_Scheme_MedicationID",gxold:"O332BR_Scheme_MedicationID",gxvar:"A332BR_Scheme_MedicationID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z332BR_Scheme_MedicationID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_SCHEME_MEDICATIONID",gx.O.A332BR_Scheme_MedicationID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A332BR_Scheme_MedicationID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_SCHEME_MEDICATIONID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 48 , function() {
   });
   GXValidFnc[49]={ id:49 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_schemeid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_SCHEMEID",gxz:"Z327BR_SchemeID",gxold:"O327BR_SchemeID",gxvar:"A327BR_SchemeID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z327BR_SchemeID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_SCHEMEID",gx.O.A327BR_SchemeID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A327BR_SchemeID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_SCHEMEID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 49 , function() {
   });
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.Z328BR_Scheme_Chem_Regimens = "" ;
   this.O328BR_Scheme_Chem_Regimens = "" ;
   this.A119BR_MedicationID = 0 ;
   this.Z119BR_MedicationID = 0 ;
   this.O119BR_MedicationID = 0 ;
   this.A121BR_Medication_RXName = "" ;
   this.Z121BR_Medication_RXName = "" ;
   this.O121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.Z124BR_Medication_RXDose = 0 ;
   this.O124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.Z125BR_Medication_RXUnit = "" ;
   this.O125BR_Medication_RXUnit = "" ;
   this.A332BR_Scheme_MedicationID = 0 ;
   this.Z332BR_Scheme_MedicationID = 0 ;
   this.O332BR_Scheme_MedicationID = 0 ;
   this.A327BR_SchemeID = 0 ;
   this.Z327BR_SchemeID = 0 ;
   this.O327BR_SchemeID = 0 ;
   this.A328BR_Scheme_Chem_Regimens = "" ;
   this.A119BR_MedicationID = 0 ;
   this.A121BR_Medication_RXName = "" ;
   this.A124BR_Medication_RXDose = 0 ;
   this.A125BR_Medication_RXUnit = "" ;
   this.A332BR_Scheme_MedicationID = 0 ;
   this.A327BR_SchemeID = 0 ;
   this.Events = {"e136k2_client": ["ENTER", true] ,"e146k2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'AV16Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_Scheme_MedicationID',fld:'vBR_SCHEME_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["LOAD"] = [[],[{av:'gx.fn.getCtrlProperty("BR_SCHEME_MEDICATIONID","Visible")',ctrl:'BR_SCHEME_MEDICATIONID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_SCHEMEID","Visible")',ctrl:'BR_SCHEMEID',prop:'Visible'}]];
   this.Initialize( );
});
