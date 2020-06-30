using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"wwpbaseobjects\gethomesampledata", "dll");
      sc.Add( @"wwpbaseobjects\gethomesamplenamevaluedata", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalityfilterparentwwgetfilterdata", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalitysecfunctionalityrolewcgetfilterdata", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalitywwgetfilterdata", "dll");
      sc.Add( @"wwpbaseobjects\secrolesecfunctionalityrolewcgetfilterdata", "dll");
      sc.Add( @"wwpbaseobjects\secrolewwgetfilterdata", "dll");
      sc.Add( @"br_demographicswwgetfilterdata", "dll");
      sc.Add( @"br_diagnosiswwgetfilterdata", "dll");
      sc.Add( @"br_labwwgetfilterdata", "dll");
      sc.Add( @"br_medicationwwgetfilterdata", "dll");
      sc.Add( @"br_procedurewwgetfilterdata", "dll");
      sc.Add( @"br_medicalimaging_diagwwgetfilterdata", "dll");
      sc.Add( @"br_medicalimagingwwgetfilterdata", "dll");
      sc.Add( @"br_medication_detailwwgetfilterdata", "dll");
      sc.Add( @"br_pathology_specimenwwgetfilterdata", "dll");
      sc.Add( @"br_pathology_diagwwgetfilterdata", "dll");
      sc.Add( @"br_pathology_otherwwgetfilterdata", "dll");
      sc.Add( @"br_pathologywwgetfilterdata", "dll");
      sc.Add( @"br_vitalwwgetfilterdata", "dll");
      sc.Add( @"br_medication_schemewwgetfilterdata", "dll");
      sc.Add( @"br_procedure_surgerywwgetfilterdata", "dll");
      sc.Add( @"br_procedure_radiowwgetfilterdata", "dll");
      sc.Add( @"br_schemewwgetfilterdata", "dll");
      sc.Add( @"br_scheme_br_scheme_medicationgetfilterdata", "dll");
      sc.Add( @"br_scheme_medicationwwgetfilterdata", "dll");
      sc.Add( @"br_medicationpromptgetfilterdata", "dll");
      sc.Add( @"xt_configwwgetfilterdata", "dll");
      sc.Add( @"br_encounterreasonwwgetfilterdata", "dll");
      sc.Add( @"br_encounter_refusereasonwwgetfilterdata", "dll");
      sc.Add( @"br_enteringsubmitdetailgetfilterdata", "dll");
      sc.Add( @"wb_checkjwtifcorrect", "dll");
      sc.Add( @"wb_checkjwtifcorrect", "dll");
      sc.Add( @"wb_getusername", "dll");
      sc.Add( @"wb_getusername", "dll");
      sc.Add( @"wb_refreshjwt", "dll");
      sc.Add( @"wb_refreshjwt", "dll");
      sc.Add( @"testwebs", "dll");
      sc.Add( @"testwebs", "dll");
      sc.Add( @"xt_intialdefinecodegetfilterdata", "dll");
      sc.Add( @"wb_refreshjwtback", "dll");
      sc.Add( @"wb_refreshjwtback", "dll");
      sc.Add( @"sys_rolepermissionwwgetfilterdata", "dll");
      sc.Add( @"jc_providerwwgetfilterdata", "dll");
      sc.Add( @"br_informationlistgetfilterdata", "dll");
      sc.Add( @"br_encounterlistgetfilterdata", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"wwpbaseobjects\addressdisplay", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"dashboard", "dll");
      sc.Add( @"wwpbaseobjects\managefilters", "dll");
      sc.Add( @"wwpbaseobjects\promptgeolocation", "dll");
      sc.Add( @"wwpbaseobjects\savefilteras", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsarrowwc", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsbulletwc", "dll");
      sc.Add( @"wwpbaseobjects\wwptabbedview", "dll");
      sc.Add( @"wwpbaseobjects\notauthorized", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalityww", "dll");
      sc.Add( @"wwpbaseobjects\secroleww", "dll");
      sc.Add( @"wwpbaseobjects\secuserview", "dll");
      sc.Add( @"wwpbaseobjects\secuserww", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalityfilterparentww", "dll");
      sc.Add( @"wwpbaseobjects\secrolefunroleassociationww", "dll");
      sc.Add( @"wwpbaseobjects\secrolefunroleactionassociationww", "dll");
      sc.Add( @"wwpbaseobjects\secusersecuserroleassociation", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalityview", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalitygeneral", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalitysecfunctionalityrolewc", "dll");
      sc.Add( @"wwpbaseobjects\seclogin", "dll");
      sc.Add( @"wwpbaseobjects\seclogin", "dll");
      sc.Add( @"wwpbaseobjects\secroleview", "dll");
      sc.Add( @"wwpbaseobjects\secrolegeneral", "dll");
      sc.Add( @"wwpbaseobjects\secrolesecfunctionalityrolewc", "dll");
      sc.Add( @"wwpbaseobjects\secrolesecuserrolewc", "dll");
      sc.Add( @"wwpbaseobjects\secuserprompt", "dll");
      sc.Add( @"wwpbaseobjects\secusergeneral", "dll");
      sc.Add( @"wwpbaseobjects\secusersecuserrolewc", "dll");
      sc.Add( @"wwpbaseobjects\secchangepassword", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpage", "dll");
      sc.Add( @"br_encounterview", "dll");
      sc.Add( @"br_encounterww", "dll");
      sc.Add( @"br_encounterprompt", "dll");
      sc.Add( @"br_encountergeneral", "dll");
      sc.Add( @"br_informationww", "dll");
      sc.Add( @"br_informationprompt", "dll");
      sc.Add( @"br_informationgeneral", "dll");
      sc.Add( @"br_informationview", "dll");
      sc.Add( @"secuser_update", "dll");
      sc.Add( @"br_encounterupdate", "dll");
      sc.Add( @"br_encounterupdategeneral", "dll");
      sc.Add( @"br_encounterupdatebr_diagnosiswc", "dll");
      sc.Add( @"br_encounterupdatebr_labwc", "dll");
      sc.Add( @"br_encounterupdatebr_medicationwc", "dll");
      sc.Add( @"br_encounterupdatebr_procedurewc", "dll");
      sc.Add( @"xt_defindcodetypeview", "dll");
      sc.Add( @"xt_defindcodetypeww", "dll");
      sc.Add( @"xt_defindcodetypeprompt", "dll");
      sc.Add( @"xt_defindcodetypegeneral", "dll");
      sc.Add( @"xt_defindcodetypext_definecodewc", "dll");
      sc.Add( @"xt_definecodeview", "dll");
      sc.Add( @"xt_definecodeww", "dll");
      sc.Add( @"xt_definecodeprompt", "dll");
      sc.Add( @"xt_definecodegeneral", "dll");
      sc.Add( @"br_encounterupdatedemographics", "dll");
      sc.Add( @"br_demographicsww", "dll");
      sc.Add( @"br_demographicsprompt", "dll");
      sc.Add( @"br_demographicsgeneral", "dll");
      sc.Add( @"br_demographicsview", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"br_encounterupdatebehavior", "dll");
      sc.Add( @"br_encounterupdatecomorbidity", "dll");
      sc.Add( @"br_encounterupdatedeath", "dll");
      sc.Add( @"br_medicationupdate", "dll");
      sc.Add( @"br_procedureinsert", "dll");
      sc.Add( @"br_diagnosisww", "dll");
      sc.Add( @"br_diagnosisprompt", "dll");
      sc.Add( @"br_diagnosisgeneral", "dll");
      sc.Add( @"br_diagnosisview", "dll");
      sc.Add( @"br_labww", "dll");
      sc.Add( @"br_labprompt", "dll");
      sc.Add( @"br_labgeneral", "dll");
      sc.Add( @"br_labview", "dll");
      sc.Add( @"br_medicationww", "dll");
      sc.Add( @"br_medicationprompt", "dll");
      sc.Add( @"br_medicationgeneral", "dll");
      sc.Add( @"br_medicationview", "dll");
      sc.Add( @"br_procedureww", "dll");
      sc.Add( @"br_procedureprompt", "dll");
      sc.Add( @"br_proceduregeneral", "dll");
      sc.Add( @"br_procedureview", "dll");
      sc.Add( @"br_encountercheck", "dll");
      sc.Add( @"br_encountercheckgeneral", "dll");
      sc.Add( @"br_encountercheckdemographics", "dll");
      sc.Add( @"br_encountercheckbehavior", "dll");
      sc.Add( @"br_encountercheckcomorbidity", "dll");
      sc.Add( @"br_encountercheckdeath", "dll");
      sc.Add( @"br_encountercheckbr_diagnosiswc", "dll");
      sc.Add( @"br_encountercheckbr_labwc", "dll");
      sc.Add( @"br_encountercheckbr_medicationwc", "dll");
      sc.Add( @"br_encountercheckbr_procedurewc", "dll");
      sc.Add( @"wwpbaseobjects\secrolesecuserroleassociationww", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalitysecfunctionalityroleassociation", "dll");
      sc.Add( @"wwpbaseobjects\secuserjc_providersecuserassociation", "dll");
      sc.Add( @"jc_selectprovider", "dll");
      sc.Add( @"br_encountertab", "dll");
      sc.Add( @"br_encounterdetail", "dll");
      sc.Add( @"xt_logview", "dll");
      sc.Add( @"xt_logww", "dll");
      sc.Add( @"xt_logprompt", "dll");
      sc.Add( @"xt_loggeneral", "dll");
      sc.Add( @"br_medicalimaging_diagview", "dll");
      sc.Add( @"br_medicalimaging_diagww", "dll");
      sc.Add( @"br_medicalimaging_diaggeneral", "dll");
      sc.Add( @"br_medicalimagingview", "dll");
      sc.Add( @"br_medicalimagingww", "dll");
      sc.Add( @"br_medicalimaginggeneral", "dll");
      sc.Add( @"br_medicalimagingbr_medicalimaging_diagwc", "dll");
      sc.Add( @"br_medication_detailview", "dll");
      sc.Add( @"br_medication_detailww", "dll");
      sc.Add( @"br_medication_detailgeneral", "dll");
      sc.Add( @"br_medication_schemeview", "dll");
      sc.Add( @"br_medication_schemeww", "dll");
      sc.Add( @"br_medication_schemegeneral", "dll");
      sc.Add( @"br_medication_schemebr_medication_detailwc", "dll");
      sc.Add( @"br_pathology_specimenview", "dll");
      sc.Add( @"br_pathology_specimenww", "dll");
      sc.Add( @"br_pathology_diagview", "dll");
      sc.Add( @"br_pathology_diagww", "dll");
      sc.Add( @"br_pathology_otherview", "dll");
      sc.Add( @"br_pathology_otherww", "dll");
      sc.Add( @"br_pathology_specimengeneral", "dll");
      sc.Add( @"br_pathology_diaggeneral", "dll");
      sc.Add( @"br_pathology_othergeneral", "dll");
      sc.Add( @"br_pathologyview", "dll");
      sc.Add( @"br_pathologyww", "dll");
      sc.Add( @"br_pathologygeneral", "dll");
      sc.Add( @"br_pathologybr_pathology_specimenwc", "dll");
      sc.Add( @"br_pathologybr_pathology_diagwc", "dll");
      sc.Add( @"br_pathologybr_pathology_otherwc", "dll");
      sc.Add( @"br_encounterupdatebr_medicalimagingwc", "dll");
      sc.Add( @"br_encounterupdatebr_pathologywc", "dll");
      sc.Add( @"br_encountercheckbr_medicalimagingwc", "dll");
      sc.Add( @"br_encountercheckbr_pathologywc", "dll");
      sc.Add( @"br_medicalimagingprompt", "dll");
      sc.Add( @"br_pathologyprompt", "dll");
      sc.Add( @"br_medicalimaging_diagprompt", "dll");
      sc.Add( @"br_pathology_specimenprompt", "dll");
      sc.Add( @"br_pathology_diagprompt", "dll");
      sc.Add( @"br_pathology_otherprompt", "dll");
      sc.Add( @"br_medication_schemeprompt", "dll");
      sc.Add( @"br_medication_detailprompt", "dll");
      sc.Add( @"br_labupdate", "dll");
      sc.Add( @"br_medication_schemeupdate", "dll");
      sc.Add( @"br_vitalview", "dll");
      sc.Add( @"br_vitalww", "dll");
      sc.Add( @"br_vitalgeneral", "dll");
      sc.Add( @"br_encounterupdatebr_vitalwc", "dll");
      sc.Add( @"br_encountercheckvitalwc", "dll");
      sc.Add( @"br_vitalprompt", "dll");
      sc.Add( @"br_procedurebr_procedure_surgerywc", "dll");
      sc.Add( @"br_procedurebr_procedure_radiowc", "dll");
      sc.Add( @"br_procedure_surgeryview", "dll");
      sc.Add( @"br_procedure_surgeryww", "dll");
      sc.Add( @"br_procedure_radioview", "dll");
      sc.Add( @"br_procedure_radioww", "dll");
      sc.Add( @"br_procedure_radiogeneral", "dll");
      sc.Add( @"br_procedure_surgerygeneral", "dll");
      sc.Add( @"br_procedure_radioprompt", "dll");
      sc.Add( @"br_procedure_surgeryprompt", "dll");
      sc.Add( @"br_schemeview", "dll");
      sc.Add( @"br_schemeww", "dll");
      sc.Add( @"br_schemeprompt", "dll");
      sc.Add( @"br_schemegeneral", "dll");
      sc.Add( @"br_scheme_br_scheme_medication", "dll");
      sc.Add( @"br_scheme_medicationview", "dll");
      sc.Add( @"br_scheme_medicationww", "dll");
      sc.Add( @"br_scheme_medicationgeneral", "dll");
      sc.Add( @"br_encounterupdatebr_schemewc", "dll");
      sc.Add( @"br_encountercheckbr_schemewc", "dll");
      sc.Add( @"br_schemeupdate", "dll");
      sc.Add( @"br_scheme_medicationprompt", "dll");
      sc.Add( @"br_informationoperate", "dll");
      sc.Add( @"br_medicalimaging_uploadimage", "dll");
      sc.Add( @"br_medicalshowupoloadimage", "dll");
      sc.Add( @"br_medicalqrcode", "dll");
      sc.Add( @"br_sduploadimage", "dll");
      sc.Add( @"br_uploadsuccessfully", "dll");
      sc.Add( @"xt_configview", "dll");
      sc.Add( @"xt_configww", "dll");
      sc.Add( @"xt_configgeneral", "dll");
      sc.Add( @"xt_configprompt", "dll");
      sc.Add( @"beizhu", "dll");
      sc.Add( @"br_pathology_otherdelete", "dll");
      sc.Add( @"br_encounterreasonview", "dll");
      sc.Add( @"br_encounterreasonww", "dll");
      sc.Add( @"br_encounterreasongeneral", "dll");
      sc.Add( @"br_enteringsubmit", "dll");
      sc.Add( @"br_encounterreasonprompt", "dll");
      sc.Add( @"br_scheme_medicationupdate", "dll");
      sc.Add( @"br_encounter_refusereasonview", "dll");
      sc.Add( @"br_encounter_refusereasonww", "dll");
      sc.Add( @"br_enteringsubmitdetail", "dll");
      sc.Add( @"br_encounter_refusereasonprompt", "dll");
      sc.Add( @"br_encounter_refusereasongeneral", "dll");
      sc.Add( @"br_enteringreaptcheck", "dll");
      sc.Add( @"wwpbaseobjects\datamanager_direct", "dll");
      sc.Add( @"wwpbaseobjects\seclogout", "dll");
      sc.Add( @"showcookie", "dll");
      sc.Add( @"br_choosetenent", "dll");
      sc.Add( @"xt_definecodeoperate", "dll");
      sc.Add( @"wwpbaseobjects\homeback", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpagenu", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpageap", "dll");
      sc.Add( @"wwpbaseobjects\notauthorized1", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpageback", "dll");
      sc.Add( @"br_informationbr_patientreentityassociation", "dll");
      sc.Add( @"wwpbaseobjects\secloginback", "dll");
      sc.Add( @"test_getjwtnewtoken", "dll");
      sc.Add( @"xt_intialdefinecode", "dll");
      sc.Add( @"dmindex", "dll");
      sc.Add( @"br_informationbr_patientretenantassociation", "dll");
      sc.Add( @"sys_rolepermissionview", "dll");
      sc.Add( @"sys_rolepermissionww", "dll");
      sc.Add( @"sys_rolepermissiongeneral", "dll");
      sc.Add( @"sys_rolepermissionprompt", "dll");
      sc.Add( @"br_medicationpromptitl", "dll");
      sc.Add( @"jc_providerview", "dll");
      sc.Add( @"jc_providerww", "dll");
      sc.Add( @"jc_providerprompt", "dll");
      sc.Add( @"jc_providergeneral", "dll");
      sc.Add( @"jc_providerjc_providersecuserwc", "dll");
      sc.Add( @"jc_providerjc_provider_br_informationwc", "dll");
      sc.Add( @"br_diagnosisinsert", "dll");
      sc.Add( @"br_diagnosisupdate", "dll");
      sc.Add( @"br_diagnosisdelete", "dll");
      sc.Add( @"br_labinsert", "dll");
      sc.Add( @"br_labdelete", "dll");
      sc.Add( @"br_medicationinsert", "dll");
      sc.Add( @"br_procedureupdate", "dll");
      sc.Add( @"xt_definecodedelete", "dll");
      sc.Add( @"br_encounterinsert", "dll");
      sc.Add( @"br_medicalimaging_diaginsert", "dll");
      sc.Add( @"br_medicalimaging_diagupdate", "dll");
      sc.Add( @"br_medicalimaging_diagdelete", "dll");
      sc.Add( @"br_pathology_specimeninsert", "dll");
      sc.Add( @"br_pathology_specimenupdate", "dll");
      sc.Add( @"br_pathology_specimendelete", "dll");
      sc.Add( @"br_pathology_diaginsert", "dll");
      sc.Add( @"br_pathology_diagupdate", "dll");
      sc.Add( @"br_pathology_diagdelete", "dll");
      sc.Add( @"br_pathology_otherinsert", "dll");
      sc.Add( @"br_pathology_otherupdate", "dll");
      sc.Add( @"br_medicalimaginginsert", "dll");
      sc.Add( @"br_medicalimagingupdate", "dll");
      sc.Add( @"br_pathologyinsert", "dll");
      sc.Add( @"br_pathologyupdate", "dll");
      sc.Add( @"br_vitalinsert", "dll");
      sc.Add( @"br_vitalupdate", "dll");
      sc.Add( @"br_vitaldelete", "dll");
      sc.Add( @"br_procedure_surgeryinsert", "dll");
      sc.Add( @"br_procedure_surgeryupate", "dll");
      sc.Add( @"br_procedure_surgerydelete", "dll");
      sc.Add( @"br_procedure_radioinsert", "dll");
      sc.Add( @"br_procedure_radioupdate", "dll");
      sc.Add( @"br_procedure_radiodelete", "dll");
      sc.Add( @"br_scheminsert", "dll");
      sc.Add( @"br_informationlist", "dll");
      sc.Add( @"dashboardnotauthorized", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpagedm", "dll");
      sc.Add( @"dmnotauthorized", "dll");
      sc.Add( @"webpanel1", "dll");
      sc.Add( @"webpanel2", "dll");
      sc.Add( @"br_encounterinsertn", "dll");
      sc.Add( @"webpanel3", "dll");
      sc.Add( @"br_encounterlist", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionality", "dll");
      sc.Add( @"wwpbaseobjects\secfunctionalityrole", "dll");
      sc.Add( @"wwpbaseobjects\secobject", "dll");
      sc.Add( @"wwpbaseobjects\secrole", "dll");
      sc.Add( @"wwpbaseobjects\secuser", "dll");
      sc.Add( @"wwpbaseobjects\secuserrole", "dll");
      sc.Add( @"wwpbaseobjects\usercustomizations", "dll");
      sc.Add( @"br_behavior", "dll");
      sc.Add( @"br_comorbidity", "dll");
      sc.Add( @"br_death", "dll");
      sc.Add( @"br_demographics", "dll");
      sc.Add( @"br_diagnosis", "dll");
      sc.Add( @"br_encounter", "dll");
      sc.Add( @"br_information", "dll");
      sc.Add( @"br_lab", "dll");
      sc.Add( @"br_medication", "dll");
      sc.Add( @"br_procedure", "dll");
      sc.Add( @"br_vital", "dll");
      sc.Add( @"jc_provider", "dll");
      sc.Add( @"xt_defindcodetype", "dll");
      sc.Add( @"xt_definecode", "dll");
      sc.Add( @"xt_log", "dll");
      sc.Add( @"jc_providersecuser", "dll");
      sc.Add( @"xt_config", "dll");
      sc.Add( @"jc_provider_br_information", "dll");
      sc.Add( @"br_medicalimaging_diag", "dll");
      sc.Add( @"br_medicalimaging", "dll");
      sc.Add( @"br_medication_detail", "dll");
      sc.Add( @"br_medication_scheme", "dll");
      sc.Add( @"br_pathology_specimen", "dll");
      sc.Add( @"br_pathology_diag", "dll");
      sc.Add( @"br_pathology_other", "dll");
      sc.Add( @"br_pathology", "dll");
      sc.Add( @"br_procedure_surgery", "dll");
      sc.Add( @"br_procedure_radio", "dll");
      sc.Add( @"br_scheme", "dll");
      sc.Add( @"br_scheme_medication", "dll");
      sc.Add( @"br_encounterreason", "dll");
      sc.Add( @"br_encounter_refusereason", "dll");
      sc.Add( @"sys_userrole", "dll");
      sc.Add( @"sys_serialnumber", "dll");
      sc.Add( @"sys_tenantuser", "dll");
      sc.Add( @"sys_permission", "dll");
      sc.Add( @"sys_tenantuseraccess", "dll");
      sc.Add( @"sys_database", "dll");
      sc.Add( @"sys_instituteuser", "dll");
      sc.Add( @"sys_user", "dll");
      sc.Add( @"sys_instituteuserrole", "dll");
      sc.Add( @"bas_tenant", "dll");
      sc.Add( @"sys_rolepermission", "dll");
      sc.Add( @"sys_role", "dll");
      sc.Add( @"bas_datapackage", "dll");
      sc.Add( @"sys_tenantuserrole", "dll");
      sc.Add( @"bas_institute", "dll");
      sc.Add( @"sys_log", "dll");
      sc.Add( @"br_patientretenant", "dll");
      sc.Add( @"br_patientreentity", "dll");
      sc.Add( @"view_lastest_patient_info", "dll");
      sc.Add( @"view_new_encounter", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.chs.dll", cs_path + @"\messages.chs.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecFunctionalityRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecUserRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtUserCustomizations.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Behavior.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Demographics.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Diagnosis.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Information.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Encounter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Lab.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_Provider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Vital.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_DefindcodeType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_DefineCode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Medication.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_ProviderSecUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_Log.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_Provider_Br_Information.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Procedure.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Comorbidity.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Death.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJWTDecode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJWTEncode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMd5.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJWTRefreshCode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtEncrypt_Method.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainfckeditorobjectinterface.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainfckeditormodes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_approvereasonstatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_encounterreason_vstatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_encryptkey.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_isintialdata.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_datasource.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpdomains.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainpage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainexporttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainhomesampledatastatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewercharttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweroutputtype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerplotseries.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewershowdataas.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerorientation.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewertrendperiod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerxaxislabels.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraggregationtype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraxisordertype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryvieweraxistype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerconditionoperator.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerexpandcollapse.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerfiltertype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewerobjecttype.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewersubtotals.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainqueryviewershowdatalabelsin.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomainwwpsecfunctionalitytypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_password.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_iscomorbidity.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_approvestatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\gxdomaindm_logoperatetype.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.chs.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.chs.txt" ))
            return true;
      }
      return false ;
   }

}

