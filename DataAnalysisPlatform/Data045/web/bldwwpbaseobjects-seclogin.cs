using System;
using GeneXus.Builder;
using System.IO;
public class bldwwpbaseobjects_seclogin : GxBaseBuilder
{
   string cs_path = "." ;
   public bldwwpbaseobjects_seclogin( ) : base()
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
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldwwpbaseobjects_seclogin x = new bldwwpbaseobjects_seclogin() ;
      x.SetMainSourceFile( "wwpbaseobjects\\seclogin.cs");
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
      sc.Add( @"wwpbaseobjects\seclogin", "dll");
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
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecObject.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecObject_Functionalities.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecFunctionalityRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecUserRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtUserCustomizations.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecFunctionality.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\wwpbaseobjects\type_SdtSecUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Death.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Comorbidity.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Behavior.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Demographics.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Diagnosis.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Information.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Lab.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Encounter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Vital.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Medication.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_Provider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_DefindcodeType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_ProviderSecUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_DefineCode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_Config.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtXT_Log.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtJC_Provider_Br_Information.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_MedicalImaging_Diag.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Medication_Detail.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_MedicalImaging.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Medication_Scheme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Pathology_Specimen.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Pathology_Diag.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Pathology_Other.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Procedure_Surgery.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Pathology.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Procedure_Radio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Procedure.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Scheme.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Scheme_Medication.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_EncounterReason.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_SerialNumber.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_UserRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Encounter_RefuseReason.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_TenantUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_TenantUserAccess.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_Permission.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_Database.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_User.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_InstituteUserRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBAS_Tenant.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_RolePermission.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBAS_DataPackage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_InstituteUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_Role.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_TenantUserRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSYS_Log.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBAS_Institute.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_PatientReEntity.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_PatientReTenant.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_Sdtview_lastest_patient_info.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtBR_Familyhistory.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtView_New_Encounter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtView_New_Encounter2.cs" ))
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

