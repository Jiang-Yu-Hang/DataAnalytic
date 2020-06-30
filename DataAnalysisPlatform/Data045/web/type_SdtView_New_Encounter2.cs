/*
               File: type_SdtView_New_Encounter2
        Description: View_New_Encounter2
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:8.12
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "View_New_Encounter2" )]
   [XmlType(TypeName =  "View_New_Encounter2" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtView_New_Encounter2 : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtView_New_Encounter2( )
      {
      }

      public SdtView_New_Encounter2( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( long AV591View_New_Encounter2view_NE_EncounterID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV591View_New_Encounter2view_NE_EncounterID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"View_New_Encounter2view_NE_EncounterID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "View_New_Encounter2");
         metadata.Set("BT", "View_New_Encounter");
         metadata.Set("PK", "[ \"View_New_Encounter2view_NE_EncounterID\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_View_new_encounter2view_ne_encounterid_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_enctype_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_departmentadm_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_admitdate_Z_Nullable");
         state.Add("gxTpr_View_new_encounter2view_ne_status_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_israndrecheck_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_israndapprove_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_isupdate_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_tenanttenantcode_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_information_id_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_information_patientno_Z");
         state.Add("gxTpr_View_new_encounter2view_ne_enctype_N");
         state.Add("gxTpr_View_new_encounter2view_ne_departmentadm_N");
         state.Add("gxTpr_View_new_encounter2view_ne_admitdate_N");
         state.Add("gxTpr_View_new_encounter2view_ne_status_N");
         state.Add("gxTpr_View_new_encounter2view_ne_israndrecheck_N");
         state.Add("gxTpr_View_new_encounter2view_ne_israndapprove_N");
         state.Add("gxTpr_View_new_encounter2view_ne_isupdate_N");
         state.Add("gxTpr_View_new_encounter2view_ne_tenanttenantcode_N");
         state.Add("gxTpr_View_new_encounter2view_ne_information_id_N");
         state.Add("gxTpr_View_new_encounter2view_ne_information_patientno_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtView_New_Encounter2 sdt ;
         sdt = (SdtView_New_Encounter2)(source);
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno ;
         gxTv_SdtView_New_Encounter2_Mode = sdt.gxTv_SdtView_New_Encounter2_Mode ;
         gxTv_SdtView_New_Encounter2_Initialized = sdt.gxTv_SdtView_New_Encounter2_Initialized ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N ;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("View_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid), 18, 0)), false);
         AddObjectProperty("View_New_Encounter2view_NE_ENCType", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype, false);
         AddObjectProperty("View_New_Encounter2view_NE_ENCType_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_Departmentadm", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm, false);
         AddObjectProperty("View_New_Encounter2view_NE_Departmentadm_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("View_New_Encounter2view_NE_AdmitDate", sDateCnv, false);
         AddObjectProperty("View_New_Encounter2view_NE_AdmitDate_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_Status", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status, false);
         AddObjectProperty("View_New_Encounter2view_NE_Status_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsRandRecheck", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsRandRecheck_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsRandApprove", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsRandApprove_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsUpdate", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate, false);
         AddObjectProperty("View_New_Encounter2view_NE_IsUpdate_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_TenantTenantCode", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode, false);
         AddObjectProperty("View_New_Encounter2view_NE_TenantTenantCode_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id), 18, 0)), false);
         AddObjectProperty("View_New_Encounter2view_NE_Information_ID_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N, false);
         AddObjectProperty("View_New_Encounter2view_NE_Information_PatientNo", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno, false);
         AddObjectProperty("View_New_Encounter2view_NE_Information_PatientNo_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtView_New_Encounter2_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtView_New_Encounter2_Initialized, false);
            AddObjectProperty("View_New_Encounter2view_NE_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z), 18, 0)), false);
            AddObjectProperty("View_New_Encounter2view_NE_ENCType_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_Departmentadm_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("View_New_Encounter2view_NE_AdmitDate_Z", sDateCnv, false);
            AddObjectProperty("View_New_Encounter2view_NE_Status_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsRandRecheck_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsRandApprove_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsUpdate_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_TenantTenantCode_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z), 18, 0)), false);
            AddObjectProperty("View_New_Encounter2view_NE_Information_PatientNo_Z", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z, false);
            AddObjectProperty("View_New_Encounter2view_NE_ENCType_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_Departmentadm_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_AdmitDate_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_Status_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsRandRecheck_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsRandApprove_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_IsUpdate_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_TenantTenantCode_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_Information_ID_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N, false);
            AddObjectProperty("View_New_Encounter2view_NE_Information_PatientNo_N", gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtView_New_Encounter2 sdt )
      {
         if ( sdt.IsDirty("View_New_Encounter2view_NE_EncounterID") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_ENCType") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_Departmentadm") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_AdmitDate") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_Status") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_IsRandRecheck") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_IsRandApprove") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_IsUpdate") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_TenantTenantCode") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_Information_ID") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id ;
         }
         if ( sdt.IsDirty("View_New_Encounter2view_NE_Information_PatientNo") )
         {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno = sdt.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_EncounterID" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_EncounterID"   )]
      public long gxTpr_View_new_encounter2view_ne_encounterid
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid ;
         }

         set {
            if ( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid != value )
            {
               gxTv_SdtView_New_Encounter2_Mode = "INS";
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z_SetNull( );
               this.gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z_SetNull( );
            }
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid = value;
            SetDirty("View_new_encounter2view_ne_encounterid");
         }

      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_ENCType" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_ENCType"   )]
      public String gxTpr_View_new_encounter2view_ne_enctype
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype = value;
            SetDirty("View_new_encounter2view_ne_enctype");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Departmentadm" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Departmentadm"   )]
      public String gxTpr_View_new_encounter2view_ne_departmentadm
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm = value;
            SetDirty("View_new_encounter2view_ne_departmentadm");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_AdmitDate" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_AdmitDate"  , IsNullable=true )]
      public string gxTpr_View_new_encounter2view_ne_admitdate_Nullable
      {
         get {
            if ( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate).value ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = DateTime.MinValue;
            else
               gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_new_encounter2view_ne_admitdate
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = value;
            SetDirty("View_new_encounter2view_ne_admitdate");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Status" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Status"   )]
      public short gxTpr_View_new_encounter2view_ne_status
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status = value;
            SetDirty("View_new_encounter2view_ne_status");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck"   )]
      public bool gxTpr_View_new_encounter2view_ne_israndrecheck
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck = value;
            SetDirty("View_new_encounter2view_ne_israndrecheck");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove"   )]
      public bool gxTpr_View_new_encounter2view_ne_israndapprove
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove = value;
            SetDirty("View_new_encounter2view_ne_israndapprove");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsUpdate" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsUpdate"   )]
      public bool gxTpr_View_new_encounter2view_ne_isupdate
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate = value;
            SetDirty("View_new_encounter2view_ne_isupdate");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode"   )]
      public String gxTpr_View_new_encounter2view_ne_tenanttenantcode
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode = value;
            SetDirty("View_new_encounter2view_ne_tenanttenantcode");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_ID" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_ID"   )]
      public long gxTpr_View_new_encounter2view_ne_information_id
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id = value;
            SetDirty("View_new_encounter2view_ne_information_id");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo"   )]
      public String gxTpr_View_new_encounter2view_ne_information_patientno
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N = 0;
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno = value;
            SetDirty("View_new_encounter2view_ne_information_patientno");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N = 1;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtView_New_Encounter2_Mode ;
         }

         set {
            gxTv_SdtView_New_Encounter2_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtView_New_Encounter2_Mode_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_Mode = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtView_New_Encounter2_Initialized ;
         }

         set {
            gxTv_SdtView_New_Encounter2_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtView_New_Encounter2_Initialized_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_EncounterID_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_EncounterID_Z"   )]
      public long gxTpr_View_new_encounter2view_ne_encounterid_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z = value;
            SetDirty("View_new_encounter2view_ne_encounterid_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_ENCType_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_ENCType_Z"   )]
      public String gxTpr_View_new_encounter2view_ne_enctype_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z = value;
            SetDirty("View_new_encounter2view_ne_enctype_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Departmentadm_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Departmentadm_Z"   )]
      public String gxTpr_View_new_encounter2view_ne_departmentadm_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z = value;
            SetDirty("View_new_encounter2view_ne_departmentadm_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_AdmitDate_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_AdmitDate_Z"  , IsNullable=true )]
      public string gxTpr_View_new_encounter2view_ne_admitdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = DateTime.MinValue;
            else
               gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_new_encounter2view_ne_admitdate_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = value;
            SetDirty("View_new_encounter2view_ne_admitdate_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Status_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Status_Z"   )]
      public short gxTpr_View_new_encounter2view_ne_status_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z = value;
            SetDirty("View_new_encounter2view_ne_status_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck_Z"   )]
      public bool gxTpr_View_new_encounter2view_ne_israndrecheck_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z = value;
            SetDirty("View_new_encounter2view_ne_israndrecheck_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove_Z"   )]
      public bool gxTpr_View_new_encounter2view_ne_israndapprove_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z = value;
            SetDirty("View_new_encounter2view_ne_israndapprove_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsUpdate_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsUpdate_Z"   )]
      public bool gxTpr_View_new_encounter2view_ne_isupdate_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z = value;
            SetDirty("View_new_encounter2view_ne_isupdate_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z = false;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode_Z"   )]
      public String gxTpr_View_new_encounter2view_ne_tenanttenantcode_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z = value;
            SetDirty("View_new_encounter2view_ne_tenanttenantcode_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_ID_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_ID_Z"   )]
      public long gxTpr_View_new_encounter2view_ne_information_id_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z = value;
            SetDirty("View_new_encounter2view_ne_information_id_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo_Z"   )]
      public String gxTpr_View_new_encounter2view_ne_information_patientno_Z
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z = value;
            SetDirty("View_new_encounter2view_ne_information_patientno_Z");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_ENCType_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_ENCType_N"   )]
      public short gxTpr_View_new_encounter2view_ne_enctype_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N = value;
            SetDirty("View_new_encounter2view_ne_enctype_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Departmentadm_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Departmentadm_N"   )]
      public short gxTpr_View_new_encounter2view_ne_departmentadm_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N = value;
            SetDirty("View_new_encounter2view_ne_departmentadm_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_AdmitDate_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_AdmitDate_N"   )]
      public short gxTpr_View_new_encounter2view_ne_admitdate_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = value;
            SetDirty("View_new_encounter2view_ne_admitdate_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Status_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Status_N"   )]
      public short gxTpr_View_new_encounter2view_ne_status_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N = value;
            SetDirty("View_new_encounter2view_ne_status_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandRecheck_N"   )]
      public short gxTpr_View_new_encounter2view_ne_israndrecheck_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N = value;
            SetDirty("View_new_encounter2view_ne_israndrecheck_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsRandApprove_N"   )]
      public short gxTpr_View_new_encounter2view_ne_israndapprove_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N = value;
            SetDirty("View_new_encounter2view_ne_israndapprove_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_IsUpdate_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_IsUpdate_N"   )]
      public short gxTpr_View_new_encounter2view_ne_isupdate_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N = value;
            SetDirty("View_new_encounter2view_ne_isupdate_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_TenantTenantCode_N"   )]
      public short gxTpr_View_new_encounter2view_ne_tenanttenantcode_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N = value;
            SetDirty("View_new_encounter2view_ne_tenanttenantcode_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_ID_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_ID_N"   )]
      public short gxTpr_View_new_encounter2view_ne_information_id_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N = value;
            SetDirty("View_new_encounter2view_ne_information_id_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "View_New_Encounter2view_NE_Information_PatientNo_N"   )]
      public short gxTpr_View_new_encounter2view_ne_information_patientno_N
      {
         get {
            return gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N ;
         }

         set {
            gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N = value;
            SetDirty("View_new_encounter2view_ne_information_patientno_N");
         }

      }

      public void gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N_SetNull( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate = DateTime.MinValue;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno = "";
         gxTv_SdtView_New_Encounter2_Mode = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z = DateTime.MinValue;
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z = "";
         gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "view_new_encounter2", "GeneXus.Programs.view_new_encounter2_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status ;
      private short gxTv_SdtView_New_Encounter2_Initialized ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_Z ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_status_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_N ;
      private short gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_N ;
      private long gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid ;
      private long gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id ;
      private long gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_encounterid_Z ;
      private long gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_id_Z ;
      private String gxTv_SdtView_New_Encounter2_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate ;
      private DateTime gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_admitdate_Z ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndrecheck_Z ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_israndapprove_Z ;
      private bool gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_isupdate_Z ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_enctype_Z ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_departmentadm_Z ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_tenanttenantcode_Z ;
      private String gxTv_SdtView_New_Encounter2_View_new_encounter2view_ne_information_patientno_Z ;
   }

   [DataContract(Name = @"View_New_Encounter2", Namespace = "DataAnalysisPlatform")]
   public class SdtView_New_Encounter2_RESTInterface : GxGenericCollectionItem<SdtView_New_Encounter2>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtView_New_Encounter2_RESTInterface( ) : base()
      {
      }

      public SdtView_New_Encounter2_RESTInterface( SdtView_New_Encounter2 psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "View_New_Encounter2view_NE_EncounterID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_View_new_encounter2view_ne_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_ENCType" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_enctype
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_enctype ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_enctype = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_Departmentadm" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_departmentadm
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_departmentadm ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_departmentadm = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_AdmitDate" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_admitdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_View_new_encounter2view_ne_admitdate) ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_admitdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_Status" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_View_new_encounter2view_ne_status
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_status ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_status = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_IsRandRecheck" , Order = 5 )]
      [GxSeudo()]
      public bool gxTpr_View_new_encounter2view_ne_israndrecheck
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_israndrecheck ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_israndrecheck = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_IsRandApprove" , Order = 6 )]
      [GxSeudo()]
      public bool gxTpr_View_new_encounter2view_ne_israndapprove
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_israndapprove ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_israndapprove = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_IsUpdate" , Order = 7 )]
      [GxSeudo()]
      public bool gxTpr_View_new_encounter2view_ne_isupdate
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_isupdate ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_isupdate = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_TenantTenantCode" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_tenanttenantcode
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_tenanttenantcode ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_tenanttenantcode = value;
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_Information_ID" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_information_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_View_new_encounter2view_ne_information_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_information_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "View_New_Encounter2view_NE_Information_PatientNo" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_View_new_encounter2view_ne_information_patientno
      {
         get {
            return sdt.gxTpr_View_new_encounter2view_ne_information_patientno ;
         }

         set {
            sdt.gxTpr_View_new_encounter2view_ne_information_patientno = value;
         }

      }

      public SdtView_New_Encounter2 sdt
      {
         get {
            return (SdtView_New_Encounter2)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtView_New_Encounter2() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 11 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
