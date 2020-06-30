/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:37:48.49
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_specimen', false, function () {
   this.ServerClass =  "br_pathology_specimen" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7BR_Pathology_SpecimenID=gx.fn.getIntegerValue("vBR_PATHOLOGY_SPECIMENID",',') ;
      this.AV13Insert_BR_PathologyID=gx.fn.getIntegerValue("vINSERT_BR_PATHOLOGYID",',') ;
      this.AV16Pgmname=gx.fn.getControlValue("vPGMNAME") ;
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
      this.AV11TrnContext=gx.fn.getControlValue("vTRNCONTEXT") ;
   };
   this.Valid_Br_pathology_specimenid=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_SPECIMENID");
         this.AnyError  = 0;

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.Valid_Br_pathology_specimen_name=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("BR_PATHOLOGY_SPECIMEN_NAME");
         this.AnyError  = 0;
         if ( ((''==this.A275BR_Pathology_Specimen_Name)) )
         {
            try {
               gxballoon.setError("閫佹缁勭粐鍚嶇О鏄繀椤诲～鍐欑殑銆?);
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
   this.Valid_Br_pathologyid=function()
   {
      gx.ajax.validSrvEvt("dyncall","Valid_Br_pathologyid",["gx.num.urlDecimal(gx.O.A226BR_PathologyID,\',\',\'.\')"],[]);
      return true;
   }
   this.e120w2_client=function()
   {
      return this.executeServerEvent("AFTER TRN", true, null, false, false);
   };
   this.e130w33_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e140w33_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43];
   this.GXLastCtrlId =43;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "閫佹缁勭粐", "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PATHOLOGY_SPECIMEN_NAME",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGY_SPECIMEN_NAME", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_specimen_name,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMEN_NAME",gxz:"Z275BR_Pathology_Specimen_Name",gxold:"O275BR_Pathology_Specimen_Name",gxvar:"A275BR_Pathology_Specimen_Name",ucs:[],op:[29],ip:[29],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A275BR_Pathology_Specimen_Name=Value},v2z:function(Value){if(Value!==undefined)gx.O.Z275BR_Pathology_Specimen_Name=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_SPECIMEN_NAME",gx.O.A275BR_Pathology_Specimen_Name,0)},c2v:function(){if(this.val()!==undefined)gx.O.A275BR_Pathology_Specimen_Name=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_SPECIMEN_NAME")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"BTNTRN_ENTER",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"BTNTRN_CANCEL",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"BTNTRN_DELETE",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[42]={ id:42 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_pathology_specimenid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMENID",gxz:"Z274BR_Pathology_SpecimenID",gxold:"O274BR_Pathology_SpecimenID",gxvar:"A274BR_Pathology_SpecimenID",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A274BR_Pathology_SpecimenID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z274BR_Pathology_SpecimenID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_SPECIMENID",gx.O.A274BR_Pathology_SpecimenID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A274BR_Pathology_SpecimenID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_SPECIMENID",',')},nac:gx.falseFn};
   this.declareDomainHdlr( 42 , function() {
   });
   GXValidFnc[43]={ id:43 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Br_pathologyid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGYID",gxz:"Z226BR_PathologyID",gxold:"O226BR_PathologyID",gxvar:"A226BR_PathologyID",ucs:[],op:[],ip:[43],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.Z226BR_PathologyID=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGYID",gx.O.A226BR_PathologyID,0);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){if(this.val()!==undefined)gx.O.A226BR_PathologyID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGYID",',')},nac:function(){return (this.Gx_mode=="INS")&&!((0==this.AV13Insert_BR_PathologyID))}};
   this.declareDomainHdlr( 43 , function() {
   });
   this.A275BR_Pathology_Specimen_Name = "" ;
   this.Z275BR_Pathology_Specimen_Name = "" ;
   this.O275BR_Pathology_Specimen_Name = "" ;
   this.A274BR_Pathology_SpecimenID = 0 ;
   this.Z274BR_Pathology_SpecimenID = 0 ;
   this.O274BR_Pathology_SpecimenID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.Z226BR_PathologyID = 0 ;
   this.O226BR_PathologyID = 0 ;
   this.AV8WWPContext = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.AV9IsAuthorized = false ;
   this.AV16Pgmname = "" ;
   this.AV11TrnContext = {CallerObject:"",CallerOnDelete:false,CallerURL:"",TransactionName:"",Attributes:[]} ;
   this.AV17GXV1 = 0 ;
   this.AV13Insert_BR_PathologyID = 0 ;
   this.AV15TempBoolean = false ;
   this.AV14TrnContextAtt = {AttributeName:"",AttributeValue:""} ;
   this.AV7BR_Pathology_SpecimenID = 0 ;
   this.AV12WebSession = {} ;
   this.A274BR_Pathology_SpecimenID = 0 ;
   this.A226BR_PathologyID = 0 ;
   this.A275BR_Pathology_Specimen_Name = "" ;
   this.Gx_mode = "" ;
   this.Events = {"e120w2_client": ["AFTER TRN", true] ,"e130w33_client": ["ENTER", true] ,"e140w33_client": ["CANCEL", true]};
   this.EvtParms["ENTER"] = [[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_SpecimenID',fld:'vBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["REFRESH"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_SpecimenID',fld:'vBR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A274BR_Pathology_SpecimenID',fld:'BR_PATHOLOGY_SPECIMENID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[]];
   this.EvtParms["START"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV16Pgmname',fld:'vPGMNAME',pic:''}],[{av:'AV8WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV9IsAuthorized',fld:'vISAUTHORIZED',pic:''},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV17GXV1',fld:'vGXV1',pic:'99999999'},{av:'AV14TrnContextAtt',fld:'vTRNCONTEXTATT',pic:''},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGY_SPECIMENID","Visible")',ctrl:'BR_PATHOLOGY_SPECIMENID',prop:'Visible'},{av:'gx.fn.getCtrlProperty("BR_PATHOLOGYID","Visible")',ctrl:'BR_PATHOLOGYID',prop:'Visible'},{av:'AV15TempBoolean',fld:'vTEMPBOOLEAN',pic:''},{ctrl:'BTNTRN_ENTER',prop:'Visible'},{ctrl:'BTNTRN_CANCEL',prop:'Visible'},{ctrl:'BTNTRN_DELETE',prop:'Visible'}]];
   this.EvtParms["AFTER TRN"] = [[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}],[]];
   this.EnterCtrl = ["BTNTRN_ENTER"];
   this.setVCMap("AV7BR_Pathology_SpecimenID", "vBR_PATHOLOGY_SPECIMENID", 0, "int", 18, 0);
   this.setVCMap("AV13Insert_BR_PathologyID", "vINSERT_BR_PATHOLOGYID", 0, "int", 18, 0);
   this.setVCMap("AV16Pgmname", "vPGMNAME", 0, "char", 129, 0);
   this.setVCMap("Gx_mode", "vMODE", 0, "char", 3, 0);
   this.setVCMap("AV11TrnContext", "vTRNCONTEXT", 0, "WWPBaseObjects\WWPTransactionContext", 0, 0);
   this.Initialize( );
});
gx.createParentObj(br_pathology_specimen);
