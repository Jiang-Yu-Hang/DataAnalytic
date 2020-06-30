/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:47:45.32
*/
gx.evt.autoSkip = false;
gx.define('br_medicalimaging_diagupdate', false, function () {
   this.ServerClass =  "br_medicalimaging_diagupdate" ;
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
      this.AV10BR_MedicalImaging_Diag=gx.fn.getControlValue("vBR_MEDICALIMAGING_DIAG") ;
      this.AV12BR_MedicalImaging_DiagID=gx.fn.getIntegerValue("vBR_MEDICALIMAGING_DIAGID",',') ;
   };
   this.e138x2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e158x1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50];
   this.GXLastCtrlId =50;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "褰卞儚瀛﹁瘖鏂剰瑙?, "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_NO",gxz:"ZV19GXV1",gxold:"OV19GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV19GXV1=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_NO",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_NO",',')},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id:29 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_LOC",gxz:"ZV20GXV2",gxold:"OV20GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20GXV2=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_LOC",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_LOC")},nac:gx.falseFn};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id:34 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_ORGAN",gxz:"ZV21GXV3",gxold:"OV21GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV3=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV21GXV3=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_ORGAN",gx.O.GXV3,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV3=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_ORGAN")},nac:gx.falseFn};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id:38 ,lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_DIS",gxz:"ZV22GXV4",gxold:"OV22GXV4",gxvar:"GXV4",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV4=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV22GXV4=Value},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_DIS",gx.O.GXV4,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV4=this.val()},val:function(){return gx.fn.getControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAG_DIS")},nac:gx.falseFn};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id: 40, fld:"",grid:0};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"BTNENTER",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTNCANCEL",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"",grid:0};
   GXValidFnc[48]={ id: 48, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[49]={ id:49 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAGID",gxz:"ZV23GXV5",gxold:"OV23GXV5",gxvar:"GXV5",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV5=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV23GXV5=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAGID",gx.O.GXV5,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV5=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAGID",',')},nac:gx.falseFn};
   GXValidFnc[50]={ id:50 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGINGID",gxz:"ZV24GXV6",gxold:"OV24GXV6",gxvar:"GXV6",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV6=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV24GXV6=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGINGID",gx.O.GXV6,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV6=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGINGID",',')},nac:gx.falseFn};
   this.GXV1 = 0 ;
   this.ZV19GXV1 = 0 ;
   this.OV19GXV1 = 0 ;
   this.GXV2 = "" ;
   this.ZV20GXV2 = "" ;
   this.OV20GXV2 = "" ;
   this.GXV3 = "" ;
   this.ZV21GXV3 = "" ;
   this.OV21GXV3 = "" ;
   this.GXV4 = "" ;
   this.ZV22GXV4 = "" ;
   this.OV22GXV4 = "" ;
   this.GXV5 = 0 ;
   this.ZV23GXV5 = 0 ;
   this.OV23GXV5 = 0 ;
   this.GXV6 = 0 ;
   this.ZV24GXV6 = 0 ;
   this.OV24GXV6 = 0 ;
   this.GXV1 = 0 ;
   this.GXV2 = "" ;
   this.GXV3 = "" ;
   this.GXV4 = "" ;
   this.GXV5 = 0 ;
   this.GXV6 = 0 ;
   this.AV12BR_MedicalImaging_DiagID = 0 ;
   this.AV10BR_MedicalImaging_Diag = {BR_MedicalImaging_DiagID:0,BR_MedicalImagingID:0,BR_MedicalImaging_Diag_Loc:"",BR_MedicalImaging_Diag_Organ:"",BR_MedicalImaging_Diag_Dis:"",BR_MedicalImaging_Diag_No:0,Mode:"",Initialized:0,BR_MedicalImaging_DiagID_Z:0,BR_MedicalImagingID_Z:0,BR_MedicalImaging_Diag_Loc_Z:"",BR_MedicalImaging_Diag_Organ_Z:"",BR_MedicalImaging_Diag_Dis_Z:"",BR_MedicalImaging_Diag_No_Z:0} ;
   this.Events = {"e138x2_client": ["ENTER", true] ,"e158x1_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV12BR_MedicalImaging_DiagID',fld:'vBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[]];
   this.EvtParms["START"] = [[{av:'AV12BR_MedicalImaging_DiagID',fld:'vBR_MEDICALIMAGING_DIAGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGING_DIAGID',prop:'Visible'},{ctrl:'BR_MEDICALIMAGING_DIAG_BR_MEDICALIMAGINGID',prop:'Visible'},{av:'AV10BR_MedicalImaging_Diag',fld:'vBR_MEDICALIMAGING_DIAG',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_MedicalImaging_Diag',fld:'vBR_MEDICALIMAGING_DIAG',pic:''}],[]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10BR_MedicalImaging_Diag", "vBR_MEDICALIMAGING_DIAG", 0, "BR_MedicalImaging_Diag", 0, 0);
   this.setVCMap("AV12BR_MedicalImaging_DiagID", "vBR_MEDICALIMAGING_DIAGID", 0, "int", 18, 0);
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImaging_Diag_No"], this.GXValidFnc[25], "AV10BR_MedicalImaging_Diag");
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImaging_Diag_Loc"], this.GXValidFnc[29], "AV10BR_MedicalImaging_Diag");
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImaging_Diag_Organ"], this.GXValidFnc[34], "AV10BR_MedicalImaging_Diag");
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImaging_Diag_Dis"], this.GXValidFnc[38], "AV10BR_MedicalImaging_Diag");
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImaging_DiagID"], this.GXValidFnc[49], "AV10BR_MedicalImaging_Diag");
   this.addBCProperty("Br_medicalimaging_diag", ["BR_MedicalImagingID"], this.GXValidFnc[50], "AV10BR_MedicalImaging_Diag");
   this.Initialize( );
});
gx.createParentObj(br_medicalimaging_diagupdate);
