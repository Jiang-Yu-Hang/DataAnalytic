/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:5:20.26
*/
gx.evt.autoSkip=!1;gx.define("br_sduploadimage",!1,function(){var t,n;this.ServerClass="br_sduploadimage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV7UploadedFiles=gx.fn.getControlValue("vUPLOADEDFILES");this.AV12BR_MedicalImaging=gx.fn.getControlValue("vBR_MEDICALIMAGING");this.AV13iBR_MedicalImagingID=gx.fn.getIntegerValue("vIBR_MEDICALIMAGINGID",",");this.AV21tCurrentCode=gx.fn.getControlValue("vTCURRENTCODE")};this.e116u2_client=function(){return this.executeServerEvent("FILEUPLOAD1.UPLOADCOMPLETE",!1,null,!0,!0)};this.e156u2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e166u2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11];this.GXLastCtrlId=11;this.FILEUPLOAD1Container=gx.uc.getNew(this,12,0,"gx.uc.FileUpload","FILEUPLOAD1Container","Fileupload1","FILEUPLOAD1");n=this.FILEUPLOAD1Container;n.setProp("Enabled","Enabled",!0,"boolean");n.setProp("Class","Class","FileUpload","str");n.setProp("AutoUpload","Autoupload",!1,"bool");n.setProp("MaxFileSize","Maxfilesize",134217728,"num");n.setProp("MaxNumberOfFiles","Maxnumberoffiles",20,"num");n.setProp("AcceptedFileTypes","Acceptedfiletypes","image","str");n.setProp("CustomFileTypes","Customfiletypes","","char");n.addC2VFunction(function(n){n.ParentObject.AV7UploadedFiles=n.getFiles();gx.fn.setControlValue("vUPLOADEDFILES",n.ParentObject.AV7UploadedFiles)});n.setProp("Visible","Visible",!0,"bool");n.setC2ShowFunction(function(n){n.show()});n.addEventHandler("UploadComplete",this.e116u2_client);this.setUserControl(n);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLEMAIN",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TABLECONTENT",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};this.AV7UploadedFiles=[];this.AV13iBR_MedicalImagingID=0;this.AV21tCurrentCode="";this.AV12BR_MedicalImaging={BR_MedicalImagingID:0,BR_EncounterID:0,BR_Information_PatientNo:"",BR_MedicalImaging_ID:0,BR_MedicalImaging_No:0,BR_MedicalImaging_ImageName:"",BR_MedicalImaging_ImageName_Code:"",BR_MedicalImaging_ImageDate:gx.date.nullDate(),BR_MedicalImaging_ImageHosp:"",BR_MedicalImaging_ImageHosp_Code:"",BR_MedicalImaging_ImageAge:0,BR_MedicalImaging_ImageLoc:"",BR_MedicalImaging_ImageLoc_Code:"",BR_MedicalImaging_ImageOrgan:"",BR_MedicalImaging_PreImageDiag:"",BR_MedicalImaging_ImageDes:"",BR_MedicalImaging_TumorSize:"",BR_MedicalImaging_ImageHtml:"",BR_MedicalImaging_MetastasesDX:"",BR_MedicalImaging_MetaLoc:"",BR_MedicalImaging_MetaDate:gx.date.nullDate(),Mode:"",Initialized:0,BR_MedicalImagingID_Z:0,BR_EncounterID_Z:0,BR_Information_PatientNo_Z:"",BR_MedicalImaging_ID_Z:0,BR_MedicalImaging_No_Z:0,BR_MedicalImaging_ImageName_Z:"",BR_MedicalImaging_ImageName_Code_Z:"",BR_MedicalImaging_ImageDate_Z:gx.date.nullDate(),BR_MedicalImaging_ImageHosp_Z:"",BR_MedicalImaging_ImageHosp_Code_Z:"",BR_MedicalImaging_ImageAge_Z:0,BR_MedicalImaging_ImageLoc_Z:"",BR_MedicalImaging_ImageLoc_Code_Z:"",BR_MedicalImaging_ImageOrgan_Z:"",BR_MedicalImaging_PreImageDiag_Z:"",BR_MedicalImaging_ImageDes_Z:"",BR_MedicalImaging_TumorSize_Z:"",BR_MedicalImaging_ImageHtml_Z:"",BR_MedicalImaging_MetastasesDX_Z:"",BR_MedicalImaging_MetaLoc_Z:"",BR_MedicalImaging_MetaDate_Z:gx.date.nullDate()};this.Events={e116u2_client:["FILEUPLOAD1.UPLOADCOMPLETE",!0],e156u2_client:["ENTER",!0],e166u2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"AV13iBR_MedicalImagingID",fld:"vIBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0},{av:"AV21tCurrentCode",fld:"vTCURRENTCODE",pic:"",hsh:!0}],[]];this.EvtParms.START=[[{av:"AV21tCurrentCode",fld:"vTCURRENTCODE",pic:"",hsh:!0},{av:"AV13iBR_MedicalImagingID",fld:"vIBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ",hsh:!0}],[{av:"AV12BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""}]];this.EvtParms["FILEUPLOAD1.UPLOADCOMPLETE"]=[[{av:"AV7UploadedFiles",fld:"vUPLOADEDFILES",pic:""},{av:"AV12BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""}],[{av:"AV12BR_MedicalImaging",fld:"vBR_MEDICALIMAGING",pic:""}]];this.setVCMap("AV7UploadedFiles","vUPLOADEDFILES",0,"CollFileUploadData",0,0);this.setVCMap("AV12BR_MedicalImaging","vBR_MEDICALIMAGING",0,"BR_MedicalImaging",0,0);this.setVCMap("AV13iBR_MedicalImagingID","vIBR_MEDICALIMAGINGID",0,"int",18,0);this.setVCMap("AV21tCurrentCode","vTCURRENTCODE",0,"svchar",40,0);this.Initialize()});gx.createParentObj(br_sduploadimage)