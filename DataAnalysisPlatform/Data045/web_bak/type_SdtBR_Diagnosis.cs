/*
               File: type_SdtBR_Diagnosis
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:23.21
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
   [XmlRoot(ElementName = "BR_Diagnosis" )]
   [XmlType(TypeName =  "BR_Diagnosis" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Diagnosis : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Diagnosis( )
      {
      }

      public SdtBR_Diagnosis( IGxContext context )
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

      public void Load( long AV64BR_DiagnosisID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV64BR_DiagnosisID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_DiagnosisID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Diagnosis");
         metadata.Set("BT", "BR_Diagnosis");
         metadata.Set("PK", "[ \"BR_DiagnosisID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_DiagnosisID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_EncounterID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_diagnosisid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_diagnosis_no_Z");
         state.Add("gxTpr_Br_diagnosis_dxid_Z");
         state.Add("gxTpr_Br_diagnosis_dxcode_Z");
         state.Add("gxTpr_Br_diagnosis_dxtype_Z");
         state.Add("gxTpr_Br_diagnosis_dxtype_code_Z");
         state.Add("gxTpr_Br_diagnosis_dxtsource_Z");
         state.Add("gxTpr_Br_diagnosis_dxtsource_code_Z");
         state.Add("gxTpr_Br_diagnosis_dxdescription_Z");
         state.Add("gxTpr_Br_diagnosis_initialdx_Z");
         state.Add("gxTpr_Br_diagnosis_initialdx_code_Z");
         state.Add("gxTpr_Br_diagnosis_metastasesdx_Z");
         state.Add("gxTpr_Br_diagnosis_metastasesdx_code_Z");
         state.Add("gxTpr_Br_diagnosis_dxsource_Z");
         state.Add("gxTpr_Br_diagnosis_tumorstageclinical_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_diagnosis_no_N");
         state.Add("gxTpr_Br_diagnosis_dxid_N");
         state.Add("gxTpr_Br_diagnosis_dxcode_N");
         state.Add("gxTpr_Br_diagnosis_dxtype_N");
         state.Add("gxTpr_Br_diagnosis_dxtype_code_N");
         state.Add("gxTpr_Br_diagnosis_dxtsource_N");
         state.Add("gxTpr_Br_diagnosis_dxtsource_code_N");
         state.Add("gxTpr_Br_diagnosis_dxdescription_N");
         state.Add("gxTpr_Br_diagnosis_initialdx_N");
         state.Add("gxTpr_Br_diagnosis_initialdx_code_N");
         state.Add("gxTpr_Br_diagnosis_metastasesdx_N");
         state.Add("gxTpr_Br_diagnosis_metastasesdx_code_N");
         state.Add("gxTpr_Br_diagnosis_dxsource_N");
         state.Add("gxTpr_Br_diagnosis_tumorstageclinical_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Diagnosis sdt ;
         sdt = (SdtBR_Diagnosis)(source);
         gxTv_SdtBR_Diagnosis_Br_diagnosisid = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosisid ;
         gxTv_SdtBR_Diagnosis_Br_encounterid = sdt.gxTv_SdtBR_Diagnosis_Br_encounterid ;
         gxTv_SdtBR_Diagnosis_Br_information_patientno = sdt.gxTv_SdtBR_Diagnosis_Br_information_patientno ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_no ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical ;
         gxTv_SdtBR_Diagnosis_Mode = sdt.gxTv_SdtBR_Diagnosis_Mode ;
         gxTv_SdtBR_Diagnosis_Initialized = sdt.gxTv_SdtBR_Diagnosis_Initialized ;
         gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z ;
         gxTv_SdtBR_Diagnosis_Br_encounterid_Z = sdt.gxTv_SdtBR_Diagnosis_Br_encounterid_Z ;
         gxTv_SdtBR_Diagnosis_Br_information_patientno_Z = sdt.gxTv_SdtBR_Diagnosis_Br_information_patientno_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z ;
         gxTv_SdtBR_Diagnosis_Br_information_patientno_N = sdt.gxTv_SdtBR_Diagnosis_Br_information_patientno_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N ;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Diagnosis_Br_diagnosisid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Diagnosis_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Diagnosis_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Diagnosis_Br_information_patientno_N, false);
         AddObjectProperty("BR_Diagnosis_No", gxTv_SdtBR_Diagnosis_Br_diagnosis_no, false);
         AddObjectProperty("BR_Diagnosis_No_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N, false);
         AddObjectProperty("BR_Diagnosis_DXID", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid, false);
         AddObjectProperty("BR_Diagnosis_DXID_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N, false);
         AddObjectProperty("BR_Diagnosis_DXCode", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode, false);
         AddObjectProperty("BR_Diagnosis_DXCode_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N, false);
         AddObjectProperty("BR_Diagnosis_DXType", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype, false);
         AddObjectProperty("BR_Diagnosis_DXType_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N, false);
         AddObjectProperty("BR_Diagnosis_DXType_Code", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code, false);
         AddObjectProperty("BR_Diagnosis_DXType_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N, false);
         AddObjectProperty("BR_Diagnosis_DXTsource", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource, false);
         AddObjectProperty("BR_Diagnosis_DXTsource_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N, false);
         AddObjectProperty("BR_Diagnosis_DXTsource_Code", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code, false);
         AddObjectProperty("BR_Diagnosis_DXTsource_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N, false);
         AddObjectProperty("BR_Diagnosis_DXDescription", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription, false);
         AddObjectProperty("BR_Diagnosis_DXDescription_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N, false);
         AddObjectProperty("BR_Diagnosis_InitialDX", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx, false);
         AddObjectProperty("BR_Diagnosis_InitialDX_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N, false);
         AddObjectProperty("BR_Diagnosis_InitialDX_Code", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code, false);
         AddObjectProperty("BR_Diagnosis_InitialDX_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N, false);
         AddObjectProperty("BR_Diagnosis_MetastasesDX", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx, false);
         AddObjectProperty("BR_Diagnosis_MetastasesDX_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N, false);
         AddObjectProperty("BR_Diagnosis_MetastasesDX_Code", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code, false);
         AddObjectProperty("BR_Diagnosis_MetastasesDX_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N, false);
         AddObjectProperty("BR_Diagnosis_DXSource", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource, false);
         AddObjectProperty("BR_Diagnosis_DXSource_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N, false);
         AddObjectProperty("BR_Diagnosis_TumorStageClinical", gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical, false);
         AddObjectProperty("BR_Diagnosis_TumorStageClinical_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Diagnosis_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Diagnosis_Initialized, false);
            AddObjectProperty("BR_DiagnosisID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Diagnosis_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Diagnosis_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Diagnosis_No_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z, false);
            AddObjectProperty("BR_Diagnosis_DXID_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z, false);
            AddObjectProperty("BR_Diagnosis_DXCode_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z, false);
            AddObjectProperty("BR_Diagnosis_DXType_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z, false);
            AddObjectProperty("BR_Diagnosis_DXType_Code_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z, false);
            AddObjectProperty("BR_Diagnosis_DXTsource_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z, false);
            AddObjectProperty("BR_Diagnosis_DXTsource_Code_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z, false);
            AddObjectProperty("BR_Diagnosis_DXDescription_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z, false);
            AddObjectProperty("BR_Diagnosis_InitialDX_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z, false);
            AddObjectProperty("BR_Diagnosis_InitialDX_Code_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z, false);
            AddObjectProperty("BR_Diagnosis_MetastasesDX_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z, false);
            AddObjectProperty("BR_Diagnosis_MetastasesDX_Code_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z, false);
            AddObjectProperty("BR_Diagnosis_DXSource_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z, false);
            AddObjectProperty("BR_Diagnosis_TumorStageClinical_Z", gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Diagnosis_Br_information_patientno_N, false);
            AddObjectProperty("BR_Diagnosis_No_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N, false);
            AddObjectProperty("BR_Diagnosis_DXID_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N, false);
            AddObjectProperty("BR_Diagnosis_DXCode_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N, false);
            AddObjectProperty("BR_Diagnosis_DXType_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N, false);
            AddObjectProperty("BR_Diagnosis_DXType_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N, false);
            AddObjectProperty("BR_Diagnosis_DXTsource_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N, false);
            AddObjectProperty("BR_Diagnosis_DXTsource_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N, false);
            AddObjectProperty("BR_Diagnosis_DXDescription_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N, false);
            AddObjectProperty("BR_Diagnosis_InitialDX_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N, false);
            AddObjectProperty("BR_Diagnosis_InitialDX_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N, false);
            AddObjectProperty("BR_Diagnosis_MetastasesDX_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N, false);
            AddObjectProperty("BR_Diagnosis_MetastasesDX_Code_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N, false);
            AddObjectProperty("BR_Diagnosis_DXSource_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N, false);
            AddObjectProperty("BR_Diagnosis_TumorStageClinical_N", gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Diagnosis sdt )
      {
         if ( sdt.IsDirty("BR_DiagnosisID") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosisid = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosisid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Diagnosis_Br_encounterid = sdt.gxTv_SdtBR_Diagnosis_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Diagnosis_Br_information_patientno = sdt.gxTv_SdtBR_Diagnosis_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_No") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_no = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_no ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXID") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXCode") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXType") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXType_Code") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXTsource") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXTsource_Code") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXDescription") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_InitialDX") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_InitialDX_Code") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_MetastasesDX") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_MetastasesDX_Code") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_DXSource") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource ;
         }
         if ( sdt.IsDirty("BR_Diagnosis_TumorStageClinical") )
         {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical = sdt.gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_DiagnosisID" )]
      [  XmlElement( ElementName = "BR_DiagnosisID"   )]
      public long gxTpr_Br_diagnosisid
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosisid ;
         }

         set {
            if ( gxTv_SdtBR_Diagnosis_Br_diagnosisid != value )
            {
               gxTv_SdtBR_Diagnosis_Mode = "INS";
               this.gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z_SetNull( );
               this.gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z_SetNull( );
            }
            gxTv_SdtBR_Diagnosis_Br_diagnosisid = value;
            SetDirty("Br_diagnosisid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_information_patientno_N = 0;
            gxTv_SdtBR_Diagnosis_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_information_patientno_N = 1;
         gxTv_SdtBR_Diagnosis_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_No" )]
      [  XmlElement( ElementName = "BR_Diagnosis_No"   )]
      public long gxTpr_Br_diagnosis_no
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_no ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_no = value;
            SetDirty("Br_diagnosis_no");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_no_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_no_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXID" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXID"   )]
      public String gxTpr_Br_diagnosis_dxid
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid = value;
            SetDirty("Br_diagnosis_dxid");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXCode" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXCode"   )]
      public String gxTpr_Br_diagnosis_dxcode
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode = value;
            SetDirty("Br_diagnosis_dxcode");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType"   )]
      public String gxTpr_Br_diagnosis_dxtype
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype = value;
            SetDirty("Br_diagnosis_dxtype");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType_Code" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType_Code"   )]
      public String gxTpr_Br_diagnosis_dxtype_code
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code = value;
            SetDirty("Br_diagnosis_dxtype_code");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource"   )]
      public String gxTpr_Br_diagnosis_dxtsource
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource = value;
            SetDirty("Br_diagnosis_dxtsource");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource_Code" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource_Code"   )]
      public String gxTpr_Br_diagnosis_dxtsource_code
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code = value;
            SetDirty("Br_diagnosis_dxtsource_code");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXDescription" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXDescription"   )]
      public String gxTpr_Br_diagnosis_dxdescription
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription = value;
            SetDirty("Br_diagnosis_dxdescription");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX"   )]
      public String gxTpr_Br_diagnosis_initialdx
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx = value;
            SetDirty("Br_diagnosis_initialdx");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX_Code" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX_Code"   )]
      public String gxTpr_Br_diagnosis_initialdx_code
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code = value;
            SetDirty("Br_diagnosis_initialdx_code");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX"   )]
      public String gxTpr_Br_diagnosis_metastasesdx
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx = value;
            SetDirty("Br_diagnosis_metastasesdx");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX_Code" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX_Code"   )]
      public String gxTpr_Br_diagnosis_metastasesdx_code
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code = value;
            SetDirty("Br_diagnosis_metastasesdx_code");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXSource" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXSource"   )]
      public String gxTpr_Br_diagnosis_dxsource
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource = value;
            SetDirty("Br_diagnosis_dxsource");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_TumorStageClinical" )]
      [  XmlElement( ElementName = "BR_Diagnosis_TumorStageClinical"   )]
      public String gxTpr_Br_diagnosis_tumorstageclinical
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N = 0;
            gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical = value;
            SetDirty("Br_diagnosis_tumorstageclinical");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N = 1;
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Diagnosis_Mode ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Mode_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Diagnosis_Initialized ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Initialized_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_DiagnosisID_Z" )]
      [  XmlElement( ElementName = "BR_DiagnosisID_Z"   )]
      public long gxTpr_Br_diagnosisid_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z = value;
            SetDirty("Br_diagnosisid_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_No_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_No_Z"   )]
      public long gxTpr_Br_diagnosis_no_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z = value;
            SetDirty("Br_diagnosis_no_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXID_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXID_Z"   )]
      public String gxTpr_Br_diagnosis_dxid_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z = value;
            SetDirty("Br_diagnosis_dxid_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXCode_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXCode_Z"   )]
      public String gxTpr_Br_diagnosis_dxcode_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z = value;
            SetDirty("Br_diagnosis_dxcode_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType_Z"   )]
      public String gxTpr_Br_diagnosis_dxtype_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z = value;
            SetDirty("Br_diagnosis_dxtype_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType_Code_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType_Code_Z"   )]
      public String gxTpr_Br_diagnosis_dxtype_code_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z = value;
            SetDirty("Br_diagnosis_dxtype_code_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource_Z"   )]
      public String gxTpr_Br_diagnosis_dxtsource_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z = value;
            SetDirty("Br_diagnosis_dxtsource_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource_Code_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource_Code_Z"   )]
      public String gxTpr_Br_diagnosis_dxtsource_code_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z = value;
            SetDirty("Br_diagnosis_dxtsource_code_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXDescription_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXDescription_Z"   )]
      public String gxTpr_Br_diagnosis_dxdescription_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z = value;
            SetDirty("Br_diagnosis_dxdescription_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX_Z"   )]
      public String gxTpr_Br_diagnosis_initialdx_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z = value;
            SetDirty("Br_diagnosis_initialdx_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX_Code_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX_Code_Z"   )]
      public String gxTpr_Br_diagnosis_initialdx_code_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z = value;
            SetDirty("Br_diagnosis_initialdx_code_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX_Z"   )]
      public String gxTpr_Br_diagnosis_metastasesdx_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z = value;
            SetDirty("Br_diagnosis_metastasesdx_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX_Code_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX_Code_Z"   )]
      public String gxTpr_Br_diagnosis_metastasesdx_code_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z = value;
            SetDirty("Br_diagnosis_metastasesdx_code_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXSource_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXSource_Z"   )]
      public String gxTpr_Br_diagnosis_dxsource_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z = value;
            SetDirty("Br_diagnosis_dxsource_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_TumorStageClinical_Z" )]
      [  XmlElement( ElementName = "BR_Diagnosis_TumorStageClinical_Z"   )]
      public String gxTpr_Br_diagnosis_tumorstageclinical_Z
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z = value;
            SetDirty("Br_diagnosis_tumorstageclinical_Z");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_No_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_No_N"   )]
      public short gxTpr_Br_diagnosis_no_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N = value;
            SetDirty("Br_diagnosis_no_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXID_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXID_N"   )]
      public short gxTpr_Br_diagnosis_dxid_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N = value;
            SetDirty("Br_diagnosis_dxid_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXCode_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXCode_N"   )]
      public short gxTpr_Br_diagnosis_dxcode_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N = value;
            SetDirty("Br_diagnosis_dxcode_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType_N"   )]
      public short gxTpr_Br_diagnosis_dxtype_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N = value;
            SetDirty("Br_diagnosis_dxtype_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXType_Code_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXType_Code_N"   )]
      public short gxTpr_Br_diagnosis_dxtype_code_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N = value;
            SetDirty("Br_diagnosis_dxtype_code_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource_N"   )]
      public short gxTpr_Br_diagnosis_dxtsource_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N = value;
            SetDirty("Br_diagnosis_dxtsource_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXTsource_Code_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXTsource_Code_N"   )]
      public short gxTpr_Br_diagnosis_dxtsource_code_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N = value;
            SetDirty("Br_diagnosis_dxtsource_code_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXDescription_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXDescription_N"   )]
      public short gxTpr_Br_diagnosis_dxdescription_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N = value;
            SetDirty("Br_diagnosis_dxdescription_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX_N"   )]
      public short gxTpr_Br_diagnosis_initialdx_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N = value;
            SetDirty("Br_diagnosis_initialdx_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_InitialDX_Code_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_InitialDX_Code_N"   )]
      public short gxTpr_Br_diagnosis_initialdx_code_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N = value;
            SetDirty("Br_diagnosis_initialdx_code_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX_N"   )]
      public short gxTpr_Br_diagnosis_metastasesdx_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N = value;
            SetDirty("Br_diagnosis_metastasesdx_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_MetastasesDX_Code_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_MetastasesDX_Code_N"   )]
      public short gxTpr_Br_diagnosis_metastasesdx_code_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N = value;
            SetDirty("Br_diagnosis_metastasesdx_code_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_DXSource_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_DXSource_N"   )]
      public short gxTpr_Br_diagnosis_dxsource_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N = value;
            SetDirty("Br_diagnosis_dxsource_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Diagnosis_TumorStageClinical_N" )]
      [  XmlElement( ElementName = "BR_Diagnosis_TumorStageClinical_N"   )]
      public short gxTpr_Br_diagnosis_tumorstageclinical_N
      {
         get {
            return gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N ;
         }

         set {
            gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N = value;
            SetDirty("Br_diagnosis_tumorstageclinical_N");
         }

      }

      public void gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N_SetNull( )
      {
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Diagnosis_Br_information_patientno = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical = "";
         gxTv_SdtBR_Diagnosis_Mode = "";
         gxTv_SdtBR_Diagnosis_Br_information_patientno_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z = "";
         gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_diagnosis", "GeneXus.Programs.br_diagnosis_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Diagnosis_Initialized ;
      private short gxTv_SdtBR_Diagnosis_Br_information_patientno_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_no_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_N ;
      private short gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_N ;
      private long gxTv_SdtBR_Diagnosis_Br_diagnosisid ;
      private long gxTv_SdtBR_Diagnosis_Br_encounterid ;
      private long gxTv_SdtBR_Diagnosis_Br_diagnosis_no ;
      private long gxTv_SdtBR_Diagnosis_Br_diagnosisid_Z ;
      private long gxTv_SdtBR_Diagnosis_Br_encounterid_Z ;
      private long gxTv_SdtBR_Diagnosis_Br_diagnosis_no_Z ;
      private String gxTv_SdtBR_Diagnosis_Mode ;
      private String gxTv_SdtBR_Diagnosis_Br_information_patientno ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical ;
      private String gxTv_SdtBR_Diagnosis_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxid_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxcode_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtype_code_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxtsource_code_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxdescription_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_initialdx_code_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_metastasesdx_code_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_dxsource_Z ;
      private String gxTv_SdtBR_Diagnosis_Br_diagnosis_tumorstageclinical_Z ;
   }

   [DataContract(Name = @"BR_Diagnosis", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Diagnosis_RESTInterface : GxGenericCollectionItem<SdtBR_Diagnosis>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Diagnosis_RESTInterface( ) : base()
      {
      }

      public SdtBR_Diagnosis_RESTInterface( SdtBR_Diagnosis psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_DiagnosisID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosisid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_diagnosisid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_diagnosisid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_EncounterID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_information_patientno
      {
         get {
            return sdt.gxTpr_Br_information_patientno ;
         }

         set {
            sdt.gxTpr_Br_information_patientno = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_No" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_no
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_diagnosis_no), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_no = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXID" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxid
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxid ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxid = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXCode" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxcode
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxcode ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxcode = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXType" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxtype
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxtype ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxtype = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXType_Code" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxtype_code
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxtype_code ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxtype_code = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXTsource" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxtsource
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxtsource ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxtsource = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXTsource_Code" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxtsource_code
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxtsource_code ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxtsource_code = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXDescription" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxdescription
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxdescription ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxdescription = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_InitialDX" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_initialdx
      {
         get {
            return sdt.gxTpr_Br_diagnosis_initialdx ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_initialdx = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_InitialDX_Code" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_initialdx_code
      {
         get {
            return sdt.gxTpr_Br_diagnosis_initialdx_code ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_initialdx_code = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_MetastasesDX" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_metastasesdx
      {
         get {
            return sdt.gxTpr_Br_diagnosis_metastasesdx ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_metastasesdx = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_MetastasesDX_Code" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_metastasesdx_code
      {
         get {
            return sdt.gxTpr_Br_diagnosis_metastasesdx_code ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_metastasesdx_code = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_DXSource" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_dxsource
      {
         get {
            return sdt.gxTpr_Br_diagnosis_dxsource ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_dxsource = value;
         }

      }

      [DataMember( Name = "BR_Diagnosis_TumorStageClinical" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_diagnosis_tumorstageclinical
      {
         get {
            return sdt.gxTpr_Br_diagnosis_tumorstageclinical ;
         }

         set {
            sdt.gxTpr_Br_diagnosis_tumorstageclinical = value;
         }

      }

      public SdtBR_Diagnosis sdt
      {
         get {
            return (SdtBR_Diagnosis)Sdt ;
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
            sdt = new SdtBR_Diagnosis() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 17 )]
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
