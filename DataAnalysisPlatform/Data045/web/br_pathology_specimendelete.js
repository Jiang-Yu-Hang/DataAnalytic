/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:17:1.24
*/
gx.evt.autoSkip=!1;gx.define("br_pathology_specimendelete",!1,function(){var n,t;this.ServerClass="br_pathology_specimendelete";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV10BR_Pathology_Specimen=gx.fn.getControlValue("vBR_PATHOLOGY_SPECIMEN");this.AV12BR_Pathology_SpecimenID=gx.fn.getIntegerValue("vBR_PATHOLOGY_SPECIMENID",",")};this.e13912_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e15911_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;this.DVPANEL_TABLEATTRIBUTESContainer=gx.uc.getNew(this,16,0,"BootstrapPanel","DVPANEL_TABLEATTRIBUTESContainer","Dvpanel_tableattributes","DVPANEL_TABLEATTRIBUTES");t=this.DVPANEL_TABLEATTRIBUTESContainer;t.setProp("Class","Class","","char");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Width","Width","100%","str");t.setProp("Height","Height","100","str");t.setProp("AutoWidth","Autowidth",!1,"bool");t.setProp("AutoHeight","Autoheight",!0,"bool");t.setProp("Cls","Cls","PanelCard_BaseColor","str");t.setProp("ShowHeader","Showheader",!0,"bool");t.setProp("Title","Title","病理学送检组织","str");t.setProp("Collapsible","Collapsible",!1,"bool");t.setProp("Collapsed","Collapsed",!1,"bool");t.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");t.setProp("IconPosition","Iconposition","left","str");t.setProp("AutoScroll","Autoscroll",!1,"bool");t.setProp("Visible","Visible",!0,"bool");t.setC2ShowFunction(function(n){n.show()});this.setUserControl(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"TABLEMAIN",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"TABLECONTENT",grid:0};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"HTML_DVPANEL_TABLEATTRIBUTES",grid:0};n[18]={id:18,fld:"LAYOUT_TABLEATTRIBUTES",grid:0};n[19]={id:19,fld:"",grid:0};n[20]={id:20,fld:"TABLEATTRIBUTES",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"",grid:0};n[23]={id:23,fld:"UNNAMEDTABLEBR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,fld:"TEXTBLOCKBR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME",format:0,grid:0};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"",grid:0};n[29]={id:29,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME",gxz:"ZV17GXV1",gxold:"OV17GXV1",gxvar:"GXV1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV1=n)},v2z:function(n){n!==undefined&&(gx.O.ZV17GXV1=n)},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME",gx.O.GXV1,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV1=this.val())},val:function(){return gx.fn.getControlValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME")},nac:gx.falseFn};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"",grid:0};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[34]={id:34,fld:"BTNENTER",grid:0};n[35]={id:35,fld:"",grid:0};n[36]={id:36,fld:"BTNCANCEL",grid:0};n[37]={id:37,fld:"",grid:0};n[38]={id:38,fld:"",grid:0};n[39]={id:39,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};n[40]={id:40,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMENID",gxz:"ZV18GXV2",gxold:"OV18GXV2",gxvar:"GXV2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV2=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV18GXV2=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMENID",gx.O.GXV2,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV2=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMENID",",")},nac:gx.falseFn};n[41]={id:41,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGYID",gxz:"ZV19GXV3",gxold:"OV19GXV3",gxvar:"GXV3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.GXV3=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV19GXV3=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGYID",gx.O.GXV3,0)},c2v:function(){this.val()!==undefined&&(gx.O.GXV3=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGYID",",")},nac:gx.falseFn};this.GXV1="";this.ZV17GXV1="";this.OV17GXV1="";this.GXV2=0;this.ZV18GXV2=0;this.OV18GXV2=0;this.GXV3=0;this.ZV19GXV3=0;this.OV19GXV3=0;this.GXV1="";this.GXV2=0;this.GXV3=0;this.AV12BR_Pathology_SpecimenID=0;this.AV10BR_Pathology_Specimen={BR_Pathology_SpecimenID:0,BR_PathologyID:0,BR_Pathology_Specimen_Name:"",Mode:"",Initialized:0,BR_Pathology_SpecimenID_Z:0,BR_PathologyID_Z:0,BR_Pathology_Specimen_Name_Z:""};this.Events={e13912_client:["ENTER",!0],e15911_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV12BR_Pathology_SpecimenID",fld:"vBR_PATHOLOGY_SPECIMENID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV10BR_Pathology_Specimen.gxTpr_Br_pathology_specimen_name",fld:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMEN_NAME",pic:""}],[]];this.EvtParms.START=[[{av:"AV12BR_Pathology_SpecimenID",fld:"vBR_PATHOLOGY_SPECIMENID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{ctrl:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGY_SPECIMENID",prop:"Visible"},{ctrl:"BR_PATHOLOGY_SPECIMEN_BR_PATHOLOGYID",prop:"Visible"},{av:"AV10BR_Pathology_Specimen",fld:"vBR_PATHOLOGY_SPECIMEN",pic:""}]];this.EvtParms.ENTER=[[{av:"AV10BR_Pathology_Specimen",fld:"vBR_PATHOLOGY_SPECIMEN",pic:""}],[]];this.EvtParms.LOAD=[[{av:"AV12BR_Pathology_SpecimenID",fld:"vBR_PATHOLOGY_SPECIMENID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV10BR_Pathology_Specimen",fld:"vBR_PATHOLOGY_SPECIMEN",pic:""}]];this.EnterCtrl=["BTNENTER"];this.setVCMap("AV10BR_Pathology_Specimen","vBR_PATHOLOGY_SPECIMEN",0,"BR_Pathology_Specimen",0,0);this.setVCMap("AV12BR_Pathology_SpecimenID","vBR_PATHOLOGY_SPECIMENID",0,"int",18,0);this.addBCProperty("Br_pathology_specimen",["BR_Pathology_Specimen_Name"],this.GXValidFnc[29],"AV10BR_Pathology_Specimen");this.addBCProperty("Br_pathology_specimen",["BR_Pathology_SpecimenID"],this.GXValidFnc[40],"AV10BR_Pathology_Specimen");this.addBCProperty("Br_pathology_specimen",["BR_PathologyID"],this.GXValidFnc[41],"AV10BR_Pathology_Specimen");this.Initialize()});gx.createParentObj(br_pathology_specimendelete)