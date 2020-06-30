/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:52.40
*/
gx.evt.autoSkip = false;
gx.define('br_pathology_diagdelete', false, function () {
   this.ServerClass =  "br_pathology_diagdelete" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV10BR_Pathology_Diag=gx.fn.getControlValue("vBR_PATHOLOGY_DIAG") ;
      this.AV12BR_Pathology_DiagID=gx.fn.getIntegerValue("vBR_PATHOLOGY_DIAGID",',') ;
   };
   this.e13942_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e15941_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75];
   this.GXLastCtrlId =75;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鐥呯悊瀛﹁瘖鏂?, "str");
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
   GXValidFnc[23]={ id: 23, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"",grid:0};
   GXValidFnc[26]={ id: 26, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC", format:0,grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC",gxz:"ZV16GXV1",gxold:"OV16GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV16GXV1=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN", format:0,grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id:37 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN",gxz:"ZV17GXV2",gxold:"OV17GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17GXV2=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE", format:0,grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"",grid:0};
   GXValidFnc[46]={ id:46 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE",gxz:"ZV18GXV3",gxold:"OV18GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18GXV3=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE")},nac:gx.falseFn};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"",grid:0};
   GXValidFnc[51]={ id: 51, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE", format:0,grid:0};
   GXValidFnc[52]={ id: 52, fld:"",grid:0};
   GXValidFnc[53]={ id: 53, fld:"",grid:0};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE",gxz:"ZV19GXV4",gxold:"OV19GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE")},nac:gx.falseFn};
   GXValidFnc[55]={ id: 55, fld:"",grid:0};
   GXValidFnc[56]={ id: 56, fld:"",grid:0};
   GXValidFnc[57]={ id: 57, fld:"UNNAMEDTABLEBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE",grid:0};
   GXValidFnc[58]={ id: 58, fld:"",grid:0};
   GXValidFnc[59]={ id: 59, fld:"",grid:0};
   GXValidFnc[60]={ id: 60, fld:"TEXTBLOCKBR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE", format:0,grid:0};
   GXValidFnc[61]={ id: 61, fld:"",grid:0};
   GXValidFnc[62]={ id: 62, fld:"",grid:0};
   GXValidFnc[63]={ id:63 ,lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE",gxz:"ZV20GXV5",gxold:"OV20GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20GXV5=Value},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=this.val()},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE")},nac:gx.falseFn};
   GXValidFnc[64]={ id: 64, fld:"",grid:0};
   GXValidFnc[65]={ id: 65, fld:"",grid:0};
   GXValidFnc[66]={ id: 66, fld:"",grid:0};
   GXValidFnc[67]={ id: 67, fld:"",grid:0};
   GXValidFnc[68]={ id: 68, fld:"BTNENTER",grid:0};
   GXValidFnc[69]={ id: 69, fld:"",grid:0};
   GXValidFnc[70]={ id: 70, fld:"BTNCANCEL",grid:0};
   GXValidFnc[71]={ id: 71, fld:"",grid:0};
   GXValidFnc[72]={ id: 72, fld:"",grid:0};
   GXValidFnc[73]={ id: 73, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[74]={ id:74 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAGID",gxz:"ZV21GXV6",gxold:"OV21GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21GXV6=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAGID",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAGID",',')},nac:gx.falseFn};
   GXValidFnc[75]={ id:75 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_DIAG_BR_PATHOLOGYID",gxz:"ZV22GXV7",gxold:"OV22GXV7",gxvar:"GXV7",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV7=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV22GXV7=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGYID",gx.O.GXV7,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV7=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_DIAG_BR_PATHOLOGYID",',')},nac:gx.falseFn};
   this.GXV1 = "" ;
   this.ZV16GXV1 = "" ;
   this.OV16GXV1 = "" ;
   this.GXV2 = "" ;
   this.ZV17GXV2 = "" ;
   this.OV17GXV2 = "" ;
   this.GXV3 = "" ;
   this.ZV18GXV3 = "" ;
   this.OV18GXV3 = "" ;
   this.GXV4 = "" ;
   this.ZV19GXV4 = "" ;
   this.OV19GXV4 = "" ;
   this.GXV5 = "" ;
   this.ZV20GXV5 = "" ;
   this.OV20GXV5 = "" ;
   this.GXV6 = 0 ;
   this.ZV21GXV6 = 0 ;
   this.OV21GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.ZV22GXV7 = 0 ;
   this.OV22GXV7 = 0 ;
   this.GXV1 = "" ;
   this.GXV2 = "" ;
   this.GXV3 = "" ;
   this.GXV4 = "" ;
   this.GXV5 = "" ;
   this.GXV6 = 0 ;
   this.GXV7 = 0 ;
   this.AV12BR_Pathology_DiagID = 0 ;
   this.AV10BR_Pathology_Diag = {BR_Pathology_DiagID:0,BR_PathologyID:0,BR_Pathology_Diag_Loc:"",BR_Pathology_Diag_Organ:"",BR_Pathology_Diag_TumorType:"",BR_Pathology_Diag_TumorStage:"",BR_Pathology_Diag_TumorGrade:"",Mode:"",Initialized:0,BR_Pathology_DiagID_Z:0,BR_PathologyID_Z:0,BR_Pathology_Diag_Loc_Z:"",BR_Pathology_Diag_Organ_Z:"",BR_Pathology_Diag_TumorType_Z:"",BR_Pathology_Diag_TumorStage_Z:"",BR_Pathology_Diag_TumorGrade_Z:""} ;
   this.Events = {"e13942_client": ["ENTER", true] ,"e15941_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV12BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV10BR_Pathology_Diag.gxTpr_Br_pathology_diag_loc',fld:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_LOC',pic:''},{av:'AV10BR_Pathology_Diag.gxTpr_Br_pathology_diag_organ',fld:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_ORGAN',pic:''},{av:'AV10BR_Pathology_Diag.gxTpr_Br_pathology_diag_tumortype',fld:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORTYPE',pic:''},{av:'AV10BR_Pathology_Diag.gxTpr_Br_pathology_diag_tumorstage',fld:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORSTAGE',pic:''},{av:'AV10BR_Pathology_Diag.gxTpr_Br_pathology_diag_tumorgrade',fld:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAG_TUMORGRADE',pic:''}],[]];
   this.EvtParms["START"] = [[{av:'AV12BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_PATHOLOGY_DIAG_BR_PATHOLOGY_DIAGID',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAG_BR_PATHOLOGYID',prop:'Visible'},{av:'AV10BR_Pathology_Diag',fld:'vBR_PATHOLOGY_DIAG',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_Pathology_Diag',fld:'vBR_PATHOLOGY_DIAG',pic:''}],[]];
   this.EvtParms["LOAD"] = [[{av:'AV12BR_Pathology_DiagID',fld:'vBR_PATHOLOGY_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{av:'AV10BR_Pathology_Diag',fld:'vBR_PATHOLOGY_DIAG',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10BR_Pathology_Diag", "vBR_PATHOLOGY_DIAG", 0, "BR_Pathology_Diag", 0, 0);
   this.setVCMap("AV12BR_Pathology_DiagID", "vBR_PATHOLOGY_DIAGID", 0, "int", 18, 0);
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_Diag_Loc"], this.GXValidFnc[29], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_Diag_Organ"], this.GXValidFnc[37], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_Diag_TumorType"], this.GXValidFnc[46], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_Diag_TumorStage"], this.GXValidFnc[54], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_Diag_TumorGrade"], this.GXValidFnc[63], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_Pathology_DiagID"], this.GXValidFnc[74], "AV10BR_Pathology_Diag");
   this.addBCProperty("Br_pathology_diag", ["BR_PathologyID"], this.GXValidFnc[75], "AV10BR_Pathology_Diag");
   this.Initialize( );
});
gx.createParentObj(br_pathology_diagdelete);
