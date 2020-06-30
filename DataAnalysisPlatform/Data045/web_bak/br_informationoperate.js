/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:45:52.87
*/
gx.evt.autoSkip = false;
gx.define('br_informationoperate', false, function () {
   this.ServerClass =  "br_informationoperate" ;
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
      this.AV10BR_Information=gx.fn.getControlValue("vBR_INFORMATION") ;
      this.AV17iType=gx.fn.getIntegerValue("vITYPE",',') ;
      this.AV15tOldBR_Information_PatientNo=gx.fn.getControlValue("vTOLDBR_INFORMATION_PATIENTNO") ;
      this.AV9Context=gx.fn.getControlValue("vCONTEXT") ;
      this.AV12BR_Information_ID=gx.fn.getIntegerValue("vBR_INFORMATION_ID",',') ;
   };
   this.e136p2_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e156p1_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36];
   this.GXLastCtrlId =36;
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
   DVPANEL_TABLEATTRIBUTESContainer.setProp("Title", "Title", "鎮ｈ€呬俊鎭?, "str");
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
   GXValidFnc[25]={ id:25 ,lvl:0,type:"svchar",len:2000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_BR_INFORMATION_PATIENTNO",gxz:"ZV20GXV1",gxold:"OV20GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV1=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20GXV1=Value},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_BR_INFORMATION_PATIENTNO",gx.O.GXV1,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV1=this.val()},val:function(){return gx.fn.getControlValue("BR_INFORMATION_BR_INFORMATION_PATIENTNO")},nac:gx.falseFn};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"",grid:0};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"",grid:0};
   GXValidFnc[30]={ id: 30, fld:"BTNENTER",grid:0};
   GXValidFnc[31]={ id: 31, fld:"",grid:0};
   GXValidFnc[32]={ id: 32, fld:"BTNCANCEL",grid:0};
   GXValidFnc[33]={ id: 33, fld:"",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[36]={ id:36 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_INFORMATION_BR_INFORMATION_ID",gxz:"ZV21GXV2",gxold:"OV21GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.GXV2=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV21GXV2=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("BR_INFORMATION_BR_INFORMATION_ID",gx.O.GXV2,0)},c2v:function(){if(this.val()!==undefined)gx.O.GXV2=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("BR_INFORMATION_BR_INFORMATION_ID",',')},nac:gx.falseFn};
   this.GXV1 = "" ;
   this.ZV20GXV1 = "" ;
   this.OV20GXV1 = "" ;
   this.GXV2 = 0 ;
   this.ZV21GXV2 = 0 ;
   this.OV21GXV2 = 0 ;
   this.GXV1 = "" ;
   this.GXV2 = 0 ;
   this.AV17iType = 0 ;
   this.AV12BR_Information_ID = 0 ;
   this.AV10BR_Information = {BR_Information_ID:0,BR_Information_PatientNo:"",BR_Information_BirthDate:gx.date.nullDate(),BR_Information_CrtUser:"",BR_Information_CrtDate:gx.date.nullDate(),Mode:"",Initialized:0,BR_Information_ID_Z:0,BR_Information_PatientNo_Z:"",BR_Information_BirthDate_Z:gx.date.nullDate(),BR_Information_CrtUser_Z:"",BR_Information_CrtDate_Z:gx.date.nullDate()} ;
   this.AV15tOldBR_Information_PatientNo = "" ;
   this.AV9Context = {UserId:0,UserGUID:"",UserName:"",UserType:0,UserDisplayName:"",UserProviderID:0,UserProviderName:"",currentTNum:0,ClientIP:""} ;
   this.Events = {"e136p2_client": ["ENTER", true] ,"e156p1_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV17iType',fld:'vITYPE',pic:'ZZZ9',hsh:true},{av:'AV12BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV15tOldBR_Information_PatientNo',fld:'vTOLDBR_INFORMATION_PATIENTNO',pic:'',hsh:true}],[{av:'AV9Context',fld:'vCONTEXT',pic:''}]];
   this.EvtParms["START"] = [[{av:'AV17iType',fld:'vITYPE',pic:'ZZZ9',hsh:true},{av:'AV12BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}],[{ctrl:'BR_INFORMATION_BR_INFORMATION_ID',prop:'Visible'},{av:'AV10BR_Information',fld:'vBR_INFORMATION',pic:''},{av:'AV15tOldBR_Information_PatientNo',fld:'vTOLDBR_INFORMATION_PATIENTNO',pic:'',hsh:true}]];
   this.EvtParms["ENTER"] = [[{av:'AV10BR_Information',fld:'vBR_INFORMATION',pic:''},{av:'AV17iType',fld:'vITYPE',pic:'ZZZ9',hsh:true},{av:'AV15tOldBR_Information_PatientNo',fld:'vTOLDBR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'AV9Context',fld:'vCONTEXT',pic:''}],[{av:'AV10BR_Information',fld:'vBR_INFORMATION',pic:''}]];
   this.EnterCtrl = ["BTNENTER"];
   this.setVCMap("AV10BR_Information", "vBR_INFORMATION", 0, "BR_Information", 0, 0);
   this.setVCMap("AV17iType", "vITYPE", 0, "int", 4, 0);
   this.setVCMap("AV15tOldBR_Information_PatientNo", "vTOLDBR_INFORMATION_PATIENTNO", 0, "svchar", 2000, 0);
   this.setVCMap("AV9Context", "vCONTEXT", 0, "WWPBaseObjects\WWPContext", 0, 0);
   this.setVCMap("AV12BR_Information_ID", "vBR_INFORMATION_ID", 0, "int", 18, 0);
   this.addBCProperty("Br_information", ["BR_Information_PatientNo"], this.GXValidFnc[25], "AV10BR_Information");
   this.addBCProperty("Br_information", ["BR_Information_ID"], this.GXValidFnc[36], "AV10BR_Information");
   this.Initialize( );
});
gx.createParentObj(br_informationoperate);
