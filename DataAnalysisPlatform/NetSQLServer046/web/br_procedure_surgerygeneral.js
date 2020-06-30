/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 11:53:56.59
*/
gx.evt.autoSkip = false;
gx.define('br_procedure_surgerygeneral', true, function (CmpContext) {
   this.ServerClass =  "br_procedure_surgerygeneral" ;
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
   this.Valid_Br_procedure_surgeryid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PROCEDURE_SURGERYID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e136a2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e146a2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31];
   this.GXLastCtrlId =31;
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
   GXValidFnc[12]={ id: 12, fld:"UNNAMEDTABLEBR_PROCEDURE_SURGERY_NAME",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"TEXTBLOCKBR_PROCEDURE_SURGERY_NAME", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id:18 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_NAME",gxz:"Z321BR_Procedure_Surgery_Name",gxold:"O321BR_Procedure_Surgery_Name",gxvar:"A321BR_Procedure_Surgery_Name",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A321BR_Procedure_Surgery_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z321BR_Procedure_Surgery_Name=Value},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_NAME",gx.O.A321BR_Procedure_Surgery_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A321BR_Procedure_Surgery_Name=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_SURGERY_NAME")},nac:gx.falseFn};
   GXValidFnc[19]={ id: 19, fld:"",grid:0};
   GXValidFnc[20]={ id: 20, fld:"UNNAMEDTABLEBR_PROCEDURE_SURGERY_LOC",grid:0};
   GXValidFnc[21]={ id: 21, fld:"",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"TEXTBLOCKBR_PROCEDURE_SURGERY_LOC", format:0,grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id:26 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERY_LOC",gxz:"Z322BR_Procedure_Surgery_Loc",gxold:"O322BR_Procedure_Surgery_Loc",gxvar:"A322BR_Procedure_Surgery_Loc",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A322BR_Procedure_Surgery_Loc=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z322BR_Procedure_Surgery_Loc=Value},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERY_LOC",gx.O.A322BR_Procedure_Surgery_Loc,0)},c2v:function(){if(this.val()!==undefined)gx.O.A322BR_Procedure_Surgery_Loc=this.val()},val:function(){return gx.fn.getControlValue("BR_PROCEDURE_SURGERY_LOC")},nac:gx.falseFn};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[30]={ id:30 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_procedure_surgeryid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDURE_SURGERYID",gxz:"Z320BR_Procedure_SurgeryID",gxold:"O320BR_Procedure_SurgeryID",gxvar:"A320BR_Procedure_SurgeryID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A320BR_Procedure_SurgeryID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z320BR_Procedure_SurgeryID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDURE_SURGERYID",gx.O.A320BR_Procedure_SurgeryID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A320BR_Procedure_SurgeryID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDURE_SURGERYID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 30 , function() {
   });
   GXValidFnc[31]={ id:31 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PROCEDUREID",gxz:"Z139BR_ProcedureID",gxold:"O139BR_ProcedureID",gxvar:"A139BR_ProcedureID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z139BR_ProcedureID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PROCEDUREID",gx.O.A139BR_ProcedureID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A139BR_ProcedureID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PROCEDUREID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 31 , function() {
   });
   this.A321BR_Procedure_Surgery_Name = "" ;
   this.Z321BR_Procedure_Surgery_Name = "" ;
   this.O321BR_Procedure_Surgery_Name = "" ;
   this.A322BR_Procedure_Surgery_Loc = "" ;
   this.Z322BR_Procedure_Surgery_Loc = "" ;
   this.O322BR_Procedure_Surgery_Loc = "" ;
   this.A320BR_Procedure_SurgeryID = 0 ;
   this.Z320BR_Procedure_SurgeryID = 0 ;
   this.O320BR_Procedure_SurgeryID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.Z139BR_ProcedureID = 0 ;
   this.O139BR_ProcedureID = 0 ;
   this.A321BR_Procedure_Surgery_Name = "" ;
   this.A322BR_Procedure_Surgery_Loc = "" ;
   this.A320BR_Procedure_SurgeryID = 0 ;
   this.A139BR_ProcedureID = 0 ;
   this.Events = {"e136a2_client": ["ENTER", true] ,"e146a2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["START"] = [[{av:'AV16Pgmname',fld:'vPGMNAME',pic:''},{av:'AV8BR_Procedure_SurgeryID',fld:'vBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["LOAD"] = [[],[{av:'gx.fn.getCtrlProperty("BR_PROCEDURE_SURGERYID","Visible")',ctrl:'BR_PROCEDURE_SURGERYID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PROCEDUREID","Visible")',ctrl:'BR_PROCEDUREID',prop:'Visible'}]];
   this.Initialize( );
});
