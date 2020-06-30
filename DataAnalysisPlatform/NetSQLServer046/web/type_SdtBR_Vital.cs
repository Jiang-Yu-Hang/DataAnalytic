/*
               File: type_SdtBR_Vital
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:42.97
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
   [XmlRoot(ElementName = "BR_Vital" )]
   [XmlType(TypeName =  "BR_Vital" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Vital : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Vital( )
      {
      }

      public SdtBR_Vital( IGxContext context )
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

      public void Load( long AV150BR_VitalID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV150BR_VitalID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_VitalID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Vital");
         metadata.Set("BT", "BR_Vital");
         metadata.Set("PK", "[ \"BR_VitalID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_VitalID\" ]");
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
         state.Add("gxTpr_Br_vitalid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_vital_vitalid_Z");
         state.Add("gxTpr_Br_vital_measuredate_Z_Nullable");
         state.Add("gxTpr_Br_vital_temperature_Z_double");
         state.Add("gxTpr_Br_vital_pulse_Z_double");
         state.Add("gxTpr_Br_vital_respiration_Z_double");
         state.Add("gxTpr_Br_vital_systolic_Z_double");
         state.Add("gxTpr_Br_vital_diastolic_Z_double");
         state.Add("gxTpr_Br_vital_height_Z_double");
         state.Add("gxTpr_Br_vital_weight_Z_double");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_vital_vitalid_N");
         state.Add("gxTpr_Br_vital_measuredate_N");
         state.Add("gxTpr_Br_vital_temperature_N");
         state.Add("gxTpr_Br_vital_pulse_N");
         state.Add("gxTpr_Br_vital_respiration_N");
         state.Add("gxTpr_Br_vital_systolic_N");
         state.Add("gxTpr_Br_vital_diastolic_N");
         state.Add("gxTpr_Br_vital_height_N");
         state.Add("gxTpr_Br_vital_weight_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Vital sdt ;
         sdt = (SdtBR_Vital)(source);
         gxTv_SdtBR_Vital_Br_vitalid = sdt.gxTv_SdtBR_Vital_Br_vitalid ;
         gxTv_SdtBR_Vital_Br_encounterid = sdt.gxTv_SdtBR_Vital_Br_encounterid ;
         gxTv_SdtBR_Vital_Br_information_patientno = sdt.gxTv_SdtBR_Vital_Br_information_patientno ;
         gxTv_SdtBR_Vital_Br_vital_vitalid = sdt.gxTv_SdtBR_Vital_Br_vital_vitalid ;
         gxTv_SdtBR_Vital_Br_vital_measuredate = sdt.gxTv_SdtBR_Vital_Br_vital_measuredate ;
         gxTv_SdtBR_Vital_Br_vital_temperature = sdt.gxTv_SdtBR_Vital_Br_vital_temperature ;
         gxTv_SdtBR_Vital_Br_vital_pulse = sdt.gxTv_SdtBR_Vital_Br_vital_pulse ;
         gxTv_SdtBR_Vital_Br_vital_respiration = sdt.gxTv_SdtBR_Vital_Br_vital_respiration ;
         gxTv_SdtBR_Vital_Br_vital_systolic = sdt.gxTv_SdtBR_Vital_Br_vital_systolic ;
         gxTv_SdtBR_Vital_Br_vital_diastolic = sdt.gxTv_SdtBR_Vital_Br_vital_diastolic ;
         gxTv_SdtBR_Vital_Br_vital_height = sdt.gxTv_SdtBR_Vital_Br_vital_height ;
         gxTv_SdtBR_Vital_Br_vital_weight = sdt.gxTv_SdtBR_Vital_Br_vital_weight ;
         gxTv_SdtBR_Vital_Mode = sdt.gxTv_SdtBR_Vital_Mode ;
         gxTv_SdtBR_Vital_Initialized = sdt.gxTv_SdtBR_Vital_Initialized ;
         gxTv_SdtBR_Vital_Br_vitalid_Z = sdt.gxTv_SdtBR_Vital_Br_vitalid_Z ;
         gxTv_SdtBR_Vital_Br_encounterid_Z = sdt.gxTv_SdtBR_Vital_Br_encounterid_Z ;
         gxTv_SdtBR_Vital_Br_information_patientno_Z = sdt.gxTv_SdtBR_Vital_Br_information_patientno_Z ;
         gxTv_SdtBR_Vital_Br_vital_vitalid_Z = sdt.gxTv_SdtBR_Vital_Br_vital_vitalid_Z ;
         gxTv_SdtBR_Vital_Br_vital_measuredate_Z = sdt.gxTv_SdtBR_Vital_Br_vital_measuredate_Z ;
         gxTv_SdtBR_Vital_Br_vital_temperature_Z = sdt.gxTv_SdtBR_Vital_Br_vital_temperature_Z ;
         gxTv_SdtBR_Vital_Br_vital_pulse_Z = sdt.gxTv_SdtBR_Vital_Br_vital_pulse_Z ;
         gxTv_SdtBR_Vital_Br_vital_respiration_Z = sdt.gxTv_SdtBR_Vital_Br_vital_respiration_Z ;
         gxTv_SdtBR_Vital_Br_vital_systolic_Z = sdt.gxTv_SdtBR_Vital_Br_vital_systolic_Z ;
         gxTv_SdtBR_Vital_Br_vital_diastolic_Z = sdt.gxTv_SdtBR_Vital_Br_vital_diastolic_Z ;
         gxTv_SdtBR_Vital_Br_vital_height_Z = sdt.gxTv_SdtBR_Vital_Br_vital_height_Z ;
         gxTv_SdtBR_Vital_Br_vital_weight_Z = sdt.gxTv_SdtBR_Vital_Br_vital_weight_Z ;
         gxTv_SdtBR_Vital_Br_information_patientno_N = sdt.gxTv_SdtBR_Vital_Br_information_patientno_N ;
         gxTv_SdtBR_Vital_Br_vital_vitalid_N = sdt.gxTv_SdtBR_Vital_Br_vital_vitalid_N ;
         gxTv_SdtBR_Vital_Br_vital_measuredate_N = sdt.gxTv_SdtBR_Vital_Br_vital_measuredate_N ;
         gxTv_SdtBR_Vital_Br_vital_temperature_N = sdt.gxTv_SdtBR_Vital_Br_vital_temperature_N ;
         gxTv_SdtBR_Vital_Br_vital_pulse_N = sdt.gxTv_SdtBR_Vital_Br_vital_pulse_N ;
         gxTv_SdtBR_Vital_Br_vital_respiration_N = sdt.gxTv_SdtBR_Vital_Br_vital_respiration_N ;
         gxTv_SdtBR_Vital_Br_vital_systolic_N = sdt.gxTv_SdtBR_Vital_Br_vital_systolic_N ;
         gxTv_SdtBR_Vital_Br_vital_diastolic_N = sdt.gxTv_SdtBR_Vital_Br_vital_diastolic_N ;
         gxTv_SdtBR_Vital_Br_vital_height_N = sdt.gxTv_SdtBR_Vital_Br_vital_height_N ;
         gxTv_SdtBR_Vital_Br_vital_weight_N = sdt.gxTv_SdtBR_Vital_Br_vital_weight_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Vital_Br_vitalid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Vital_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Vital_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Vital_Br_information_patientno_N, false);
         AddObjectProperty("BR_Vital_VitalID", gxTv_SdtBR_Vital_Br_vital_vitalid, false);
         AddObjectProperty("BR_Vital_VitalID_N", gxTv_SdtBR_Vital_Br_vital_vitalid_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Vital_Br_vital_measuredate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Vital_Br_vital_measuredate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Vital_Br_vital_measuredate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Vital_MeasureDate", sDateCnv, false);
         AddObjectProperty("BR_Vital_MeasureDate_N", gxTv_SdtBR_Vital_Br_vital_measuredate_N, false);
         AddObjectProperty("BR_Vital_Temperature", gxTv_SdtBR_Vital_Br_vital_temperature, false);
         AddObjectProperty("BR_Vital_Temperature_N", gxTv_SdtBR_Vital_Br_vital_temperature_N, false);
         AddObjectProperty("BR_Vital_Pulse", gxTv_SdtBR_Vital_Br_vital_pulse, false);
         AddObjectProperty("BR_Vital_Pulse_N", gxTv_SdtBR_Vital_Br_vital_pulse_N, false);
         AddObjectProperty("BR_Vital_Respiration", gxTv_SdtBR_Vital_Br_vital_respiration, false);
         AddObjectProperty("BR_Vital_Respiration_N", gxTv_SdtBR_Vital_Br_vital_respiration_N, false);
         AddObjectProperty("BR_Vital_Systolic", gxTv_SdtBR_Vital_Br_vital_systolic, false);
         AddObjectProperty("BR_Vital_Systolic_N", gxTv_SdtBR_Vital_Br_vital_systolic_N, false);
         AddObjectProperty("BR_Vital_Diastolic", gxTv_SdtBR_Vital_Br_vital_diastolic, false);
         AddObjectProperty("BR_Vital_Diastolic_N", gxTv_SdtBR_Vital_Br_vital_diastolic_N, false);
         AddObjectProperty("BR_Vital_Height", gxTv_SdtBR_Vital_Br_vital_height, false);
         AddObjectProperty("BR_Vital_Height_N", gxTv_SdtBR_Vital_Br_vital_height_N, false);
         AddObjectProperty("BR_Vital_Weight", gxTv_SdtBR_Vital_Br_vital_weight, false);
         AddObjectProperty("BR_Vital_Weight_N", gxTv_SdtBR_Vital_Br_vital_weight_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Vital_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Vital_Initialized, false);
            AddObjectProperty("BR_VitalID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Vital_Br_vitalid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Vital_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Vital_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Vital_VitalID_Z", gxTv_SdtBR_Vital_Br_vital_vitalid_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Vital_Br_vital_measuredate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Vital_Br_vital_measuredate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Vital_Br_vital_measuredate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Vital_MeasureDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Vital_Temperature_Z", gxTv_SdtBR_Vital_Br_vital_temperature_Z, false);
            AddObjectProperty("BR_Vital_Pulse_Z", gxTv_SdtBR_Vital_Br_vital_pulse_Z, false);
            AddObjectProperty("BR_Vital_Respiration_Z", gxTv_SdtBR_Vital_Br_vital_respiration_Z, false);
            AddObjectProperty("BR_Vital_Systolic_Z", gxTv_SdtBR_Vital_Br_vital_systolic_Z, false);
            AddObjectProperty("BR_Vital_Diastolic_Z", gxTv_SdtBR_Vital_Br_vital_diastolic_Z, false);
            AddObjectProperty("BR_Vital_Height_Z", gxTv_SdtBR_Vital_Br_vital_height_Z, false);
            AddObjectProperty("BR_Vital_Weight_Z", gxTv_SdtBR_Vital_Br_vital_weight_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Vital_Br_information_patientno_N, false);
            AddObjectProperty("BR_Vital_VitalID_N", gxTv_SdtBR_Vital_Br_vital_vitalid_N, false);
            AddObjectProperty("BR_Vital_MeasureDate_N", gxTv_SdtBR_Vital_Br_vital_measuredate_N, false);
            AddObjectProperty("BR_Vital_Temperature_N", gxTv_SdtBR_Vital_Br_vital_temperature_N, false);
            AddObjectProperty("BR_Vital_Pulse_N", gxTv_SdtBR_Vital_Br_vital_pulse_N, false);
            AddObjectProperty("BR_Vital_Respiration_N", gxTv_SdtBR_Vital_Br_vital_respiration_N, false);
            AddObjectProperty("BR_Vital_Systolic_N", gxTv_SdtBR_Vital_Br_vital_systolic_N, false);
            AddObjectProperty("BR_Vital_Diastolic_N", gxTv_SdtBR_Vital_Br_vital_diastolic_N, false);
            AddObjectProperty("BR_Vital_Height_N", gxTv_SdtBR_Vital_Br_vital_height_N, false);
            AddObjectProperty("BR_Vital_Weight_N", gxTv_SdtBR_Vital_Br_vital_weight_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Vital sdt )
      {
         if ( sdt.IsDirty("BR_VitalID") )
         {
            gxTv_SdtBR_Vital_Br_vitalid = sdt.gxTv_SdtBR_Vital_Br_vitalid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Vital_Br_encounterid = sdt.gxTv_SdtBR_Vital_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Vital_Br_information_patientno = sdt.gxTv_SdtBR_Vital_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Vital_VitalID") )
         {
            gxTv_SdtBR_Vital_Br_vital_vitalid = sdt.gxTv_SdtBR_Vital_Br_vital_vitalid ;
         }
         if ( sdt.IsDirty("BR_Vital_MeasureDate") )
         {
            gxTv_SdtBR_Vital_Br_vital_measuredate = sdt.gxTv_SdtBR_Vital_Br_vital_measuredate ;
         }
         if ( sdt.IsDirty("BR_Vital_Temperature") )
         {
            gxTv_SdtBR_Vital_Br_vital_temperature = sdt.gxTv_SdtBR_Vital_Br_vital_temperature ;
         }
         if ( sdt.IsDirty("BR_Vital_Pulse") )
         {
            gxTv_SdtBR_Vital_Br_vital_pulse = sdt.gxTv_SdtBR_Vital_Br_vital_pulse ;
         }
         if ( sdt.IsDirty("BR_Vital_Respiration") )
         {
            gxTv_SdtBR_Vital_Br_vital_respiration = sdt.gxTv_SdtBR_Vital_Br_vital_respiration ;
         }
         if ( sdt.IsDirty("BR_Vital_Systolic") )
         {
            gxTv_SdtBR_Vital_Br_vital_systolic = sdt.gxTv_SdtBR_Vital_Br_vital_systolic ;
         }
         if ( sdt.IsDirty("BR_Vital_Diastolic") )
         {
            gxTv_SdtBR_Vital_Br_vital_diastolic = sdt.gxTv_SdtBR_Vital_Br_vital_diastolic ;
         }
         if ( sdt.IsDirty("BR_Vital_Height") )
         {
            gxTv_SdtBR_Vital_Br_vital_height = sdt.gxTv_SdtBR_Vital_Br_vital_height ;
         }
         if ( sdt.IsDirty("BR_Vital_Weight") )
         {
            gxTv_SdtBR_Vital_Br_vital_weight = sdt.gxTv_SdtBR_Vital_Br_vital_weight ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_VitalID" )]
      [  XmlElement( ElementName = "BR_VitalID"   )]
      public long gxTpr_Br_vitalid
      {
         get {
            return gxTv_SdtBR_Vital_Br_vitalid ;
         }

         set {
            if ( gxTv_SdtBR_Vital_Br_vitalid != value )
            {
               gxTv_SdtBR_Vital_Mode = "INS";
               this.gxTv_SdtBR_Vital_Br_vitalid_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_vitalid_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_measuredate_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_temperature_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_pulse_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_respiration_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_systolic_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_diastolic_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_height_Z_SetNull( );
               this.gxTv_SdtBR_Vital_Br_vital_weight_Z_SetNull( );
            }
            gxTv_SdtBR_Vital_Br_vitalid = value;
            SetDirty("Br_vitalid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Vital_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Vital_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Vital_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Vital_Br_information_patientno_N = 0;
            gxTv_SdtBR_Vital_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Vital_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_information_patientno_N = 1;
         gxTv_SdtBR_Vital_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_VitalID" )]
      [  XmlElement( ElementName = "BR_Vital_VitalID"   )]
      public long gxTpr_Br_vital_vitalid
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_vitalid ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_vitalid_N = 0;
            gxTv_SdtBR_Vital_Br_vital_vitalid = value;
            SetDirty("Br_vital_vitalid");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_vitalid_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_vitalid_N = 1;
         gxTv_SdtBR_Vital_Br_vital_vitalid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_vitalid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_MeasureDate" )]
      [  XmlElement( ElementName = "BR_Vital_MeasureDate"  , IsNullable=true )]
      public string gxTpr_Br_vital_measuredate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Vital_Br_vital_measuredate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Vital_Br_vital_measuredate).value ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_measuredate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Vital_Br_vital_measuredate = DateTime.MinValue;
            else
               gxTv_SdtBR_Vital_Br_vital_measuredate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_vital_measuredate
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_measuredate ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_measuredate_N = 0;
            gxTv_SdtBR_Vital_Br_vital_measuredate = value;
            SetDirty("Br_vital_measuredate");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_measuredate_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_measuredate_N = 1;
         gxTv_SdtBR_Vital_Br_vital_measuredate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_measuredate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Temperature" )]
      [  XmlElement( ElementName = "BR_Vital_Temperature"   )]
      public double gxTpr_Br_vital_temperature_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_temperature) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_temperature_N = 0;
            gxTv_SdtBR_Vital_Br_vital_temperature = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_temperature
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_temperature ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_temperature_N = 0;
            gxTv_SdtBR_Vital_Br_vital_temperature = value;
            SetDirty("Br_vital_temperature");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_temperature_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_temperature_N = 1;
         gxTv_SdtBR_Vital_Br_vital_temperature = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_temperature_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Pulse" )]
      [  XmlElement( ElementName = "BR_Vital_Pulse"   )]
      public double gxTpr_Br_vital_pulse_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_pulse) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_pulse_N = 0;
            gxTv_SdtBR_Vital_Br_vital_pulse = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_pulse
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_pulse ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_pulse_N = 0;
            gxTv_SdtBR_Vital_Br_vital_pulse = value;
            SetDirty("Br_vital_pulse");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_pulse_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_pulse_N = 1;
         gxTv_SdtBR_Vital_Br_vital_pulse = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_pulse_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Respiration" )]
      [  XmlElement( ElementName = "BR_Vital_Respiration"   )]
      public double gxTpr_Br_vital_respiration_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_respiration) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_respiration_N = 0;
            gxTv_SdtBR_Vital_Br_vital_respiration = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_respiration
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_respiration ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_respiration_N = 0;
            gxTv_SdtBR_Vital_Br_vital_respiration = value;
            SetDirty("Br_vital_respiration");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_respiration_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_respiration_N = 1;
         gxTv_SdtBR_Vital_Br_vital_respiration = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_respiration_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Systolic" )]
      [  XmlElement( ElementName = "BR_Vital_Systolic"   )]
      public double gxTpr_Br_vital_systolic_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_systolic) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_systolic_N = 0;
            gxTv_SdtBR_Vital_Br_vital_systolic = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_systolic
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_systolic ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_systolic_N = 0;
            gxTv_SdtBR_Vital_Br_vital_systolic = value;
            SetDirty("Br_vital_systolic");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_systolic_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_systolic_N = 1;
         gxTv_SdtBR_Vital_Br_vital_systolic = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_systolic_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Diastolic" )]
      [  XmlElement( ElementName = "BR_Vital_Diastolic"   )]
      public double gxTpr_Br_vital_diastolic_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_diastolic) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_diastolic_N = 0;
            gxTv_SdtBR_Vital_Br_vital_diastolic = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_diastolic
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_diastolic ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_diastolic_N = 0;
            gxTv_SdtBR_Vital_Br_vital_diastolic = value;
            SetDirty("Br_vital_diastolic");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_diastolic_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_diastolic_N = 1;
         gxTv_SdtBR_Vital_Br_vital_diastolic = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_diastolic_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Height" )]
      [  XmlElement( ElementName = "BR_Vital_Height"   )]
      public double gxTpr_Br_vital_height_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_height) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_height_N = 0;
            gxTv_SdtBR_Vital_Br_vital_height = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_height
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_height ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_height_N = 0;
            gxTv_SdtBR_Vital_Br_vital_height = value;
            SetDirty("Br_vital_height");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_height_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_height_N = 1;
         gxTv_SdtBR_Vital_Br_vital_height = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_height_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Weight" )]
      [  XmlElement( ElementName = "BR_Vital_Weight"   )]
      public double gxTpr_Br_vital_weight_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_weight) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_weight_N = 0;
            gxTv_SdtBR_Vital_Br_vital_weight = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_weight
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_weight ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_weight_N = 0;
            gxTv_SdtBR_Vital_Br_vital_weight = value;
            SetDirty("Br_vital_weight");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_weight_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_weight_N = 1;
         gxTv_SdtBR_Vital_Br_vital_weight = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_weight_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Vital_Mode ;
         }

         set {
            gxTv_SdtBR_Vital_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Vital_Mode_SetNull( )
      {
         gxTv_SdtBR_Vital_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Vital_Initialized ;
         }

         set {
            gxTv_SdtBR_Vital_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Vital_Initialized_SetNull( )
      {
         gxTv_SdtBR_Vital_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_VitalID_Z" )]
      [  XmlElement( ElementName = "BR_VitalID_Z"   )]
      public long gxTpr_Br_vitalid_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vitalid_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vitalid_Z = value;
            SetDirty("Br_vitalid_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vitalid_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vitalid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vitalid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_VitalID_Z" )]
      [  XmlElement( ElementName = "BR_Vital_VitalID_Z"   )]
      public long gxTpr_Br_vital_vitalid_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_vitalid_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_vitalid_Z = value;
            SetDirty("Br_vital_vitalid_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_vitalid_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_vitalid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_vitalid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_MeasureDate_Z" )]
      [  XmlElement( ElementName = "BR_Vital_MeasureDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_vital_measuredate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Vital_Br_vital_measuredate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Vital_Br_vital_measuredate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Vital_Br_vital_measuredate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Vital_Br_vital_measuredate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_vital_measuredate_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_measuredate_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_measuredate_Z = value;
            SetDirty("Br_vital_measuredate_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_measuredate_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_measuredate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_measuredate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Temperature_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Temperature_Z"   )]
      public double gxTpr_Br_vital_temperature_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_temperature_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_temperature_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_temperature_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_temperature_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_temperature_Z = value;
            SetDirty("Br_vital_temperature_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_temperature_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_temperature_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_temperature_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Pulse_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Pulse_Z"   )]
      public double gxTpr_Br_vital_pulse_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_pulse_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_pulse_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_pulse_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_pulse_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_pulse_Z = value;
            SetDirty("Br_vital_pulse_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_pulse_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_pulse_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_pulse_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Respiration_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Respiration_Z"   )]
      public double gxTpr_Br_vital_respiration_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_respiration_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_respiration_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_respiration_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_respiration_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_respiration_Z = value;
            SetDirty("Br_vital_respiration_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_respiration_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_respiration_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_respiration_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Systolic_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Systolic_Z"   )]
      public double gxTpr_Br_vital_systolic_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_systolic_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_systolic_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_systolic_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_systolic_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_systolic_Z = value;
            SetDirty("Br_vital_systolic_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_systolic_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_systolic_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_systolic_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Diastolic_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Diastolic_Z"   )]
      public double gxTpr_Br_vital_diastolic_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_diastolic_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_diastolic_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_diastolic_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_diastolic_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_diastolic_Z = value;
            SetDirty("Br_vital_diastolic_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_diastolic_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_diastolic_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_diastolic_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Height_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Height_Z"   )]
      public double gxTpr_Br_vital_height_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_height_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_height_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_height_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_height_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_height_Z = value;
            SetDirty("Br_vital_height_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_height_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_height_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_height_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Weight_Z" )]
      [  XmlElement( ElementName = "BR_Vital_Weight_Z"   )]
      public double gxTpr_Br_vital_weight_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Vital_Br_vital_weight_Z) ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_weight_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_vital_weight_Z
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_weight_Z ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_weight_Z = value;
            SetDirty("Br_vital_weight_Z");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_weight_Z_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_weight_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_weight_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_VitalID_N" )]
      [  XmlElement( ElementName = "BR_Vital_VitalID_N"   )]
      public short gxTpr_Br_vital_vitalid_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_vitalid_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_vitalid_N = value;
            SetDirty("Br_vital_vitalid_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_vitalid_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_vitalid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_vitalid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_MeasureDate_N" )]
      [  XmlElement( ElementName = "BR_Vital_MeasureDate_N"   )]
      public short gxTpr_Br_vital_measuredate_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_measuredate_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_measuredate_N = value;
            SetDirty("Br_vital_measuredate_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_measuredate_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_measuredate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_measuredate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Temperature_N" )]
      [  XmlElement( ElementName = "BR_Vital_Temperature_N"   )]
      public short gxTpr_Br_vital_temperature_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_temperature_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_temperature_N = value;
            SetDirty("Br_vital_temperature_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_temperature_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_temperature_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_temperature_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Pulse_N" )]
      [  XmlElement( ElementName = "BR_Vital_Pulse_N"   )]
      public short gxTpr_Br_vital_pulse_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_pulse_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_pulse_N = value;
            SetDirty("Br_vital_pulse_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_pulse_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_pulse_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_pulse_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Respiration_N" )]
      [  XmlElement( ElementName = "BR_Vital_Respiration_N"   )]
      public short gxTpr_Br_vital_respiration_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_respiration_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_respiration_N = value;
            SetDirty("Br_vital_respiration_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_respiration_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_respiration_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_respiration_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Systolic_N" )]
      [  XmlElement( ElementName = "BR_Vital_Systolic_N"   )]
      public short gxTpr_Br_vital_systolic_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_systolic_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_systolic_N = value;
            SetDirty("Br_vital_systolic_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_systolic_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_systolic_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_systolic_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Diastolic_N" )]
      [  XmlElement( ElementName = "BR_Vital_Diastolic_N"   )]
      public short gxTpr_Br_vital_diastolic_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_diastolic_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_diastolic_N = value;
            SetDirty("Br_vital_diastolic_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_diastolic_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_diastolic_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_diastolic_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Height_N" )]
      [  XmlElement( ElementName = "BR_Vital_Height_N"   )]
      public short gxTpr_Br_vital_height_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_height_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_height_N = value;
            SetDirty("Br_vital_height_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_height_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_height_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_height_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Vital_Weight_N" )]
      [  XmlElement( ElementName = "BR_Vital_Weight_N"   )]
      public short gxTpr_Br_vital_weight_N
      {
         get {
            return gxTv_SdtBR_Vital_Br_vital_weight_N ;
         }

         set {
            gxTv_SdtBR_Vital_Br_vital_weight_N = value;
            SetDirty("Br_vital_weight_N");
         }

      }

      public void gxTv_SdtBR_Vital_Br_vital_weight_N_SetNull( )
      {
         gxTv_SdtBR_Vital_Br_vital_weight_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Vital_Br_vital_weight_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Vital_Br_information_patientno = "";
         gxTv_SdtBR_Vital_Br_vital_measuredate = DateTime.MinValue;
         gxTv_SdtBR_Vital_Mode = "";
         gxTv_SdtBR_Vital_Br_information_patientno_Z = "";
         gxTv_SdtBR_Vital_Br_vital_measuredate_Z = DateTime.MinValue;
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_vital", "GeneXus.Programs.br_vital_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Vital_Initialized ;
      private short gxTv_SdtBR_Vital_Br_information_patientno_N ;
      private short gxTv_SdtBR_Vital_Br_vital_vitalid_N ;
      private short gxTv_SdtBR_Vital_Br_vital_measuredate_N ;
      private short gxTv_SdtBR_Vital_Br_vital_temperature_N ;
      private short gxTv_SdtBR_Vital_Br_vital_pulse_N ;
      private short gxTv_SdtBR_Vital_Br_vital_respiration_N ;
      private short gxTv_SdtBR_Vital_Br_vital_systolic_N ;
      private short gxTv_SdtBR_Vital_Br_vital_diastolic_N ;
      private short gxTv_SdtBR_Vital_Br_vital_height_N ;
      private short gxTv_SdtBR_Vital_Br_vital_weight_N ;
      private long gxTv_SdtBR_Vital_Br_vitalid ;
      private long gxTv_SdtBR_Vital_Br_encounterid ;
      private long gxTv_SdtBR_Vital_Br_vital_vitalid ;
      private long gxTv_SdtBR_Vital_Br_vitalid_Z ;
      private long gxTv_SdtBR_Vital_Br_encounterid_Z ;
      private long gxTv_SdtBR_Vital_Br_vital_vitalid_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_temperature ;
      private decimal gxTv_SdtBR_Vital_Br_vital_pulse ;
      private decimal gxTv_SdtBR_Vital_Br_vital_respiration ;
      private decimal gxTv_SdtBR_Vital_Br_vital_systolic ;
      private decimal gxTv_SdtBR_Vital_Br_vital_diastolic ;
      private decimal gxTv_SdtBR_Vital_Br_vital_height ;
      private decimal gxTv_SdtBR_Vital_Br_vital_weight ;
      private decimal gxTv_SdtBR_Vital_Br_vital_temperature_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_pulse_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_respiration_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_systolic_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_diastolic_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_height_Z ;
      private decimal gxTv_SdtBR_Vital_Br_vital_weight_Z ;
      private String gxTv_SdtBR_Vital_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Vital_Br_vital_measuredate ;
      private DateTime gxTv_SdtBR_Vital_Br_vital_measuredate_Z ;
      private String gxTv_SdtBR_Vital_Br_information_patientno ;
      private String gxTv_SdtBR_Vital_Br_information_patientno_Z ;
   }

   [DataContract(Name = @"BR_Vital", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Vital_RESTInterface : GxGenericCollectionItem<SdtBR_Vital>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Vital_RESTInterface( ) : base()
      {
      }

      public SdtBR_Vital_RESTInterface( SdtBR_Vital psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_VitalID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_vitalid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_vitalid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_vitalid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Vital_VitalID" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_vitalid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_vital_vitalid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_vital_vitalid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Vital_MeasureDate" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_measuredate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_vital_measuredate) ;
         }

         set {
            sdt.gxTpr_Br_vital_measuredate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Vital_Temperature" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_temperature
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_temperature, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_temperature = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Pulse" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_pulse
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_pulse, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_pulse = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Respiration" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_respiration
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_respiration, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_respiration = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Systolic" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_systolic
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_systolic, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_systolic = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Diastolic" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_diastolic
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_diastolic, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_diastolic = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Height" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_height
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_height, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_height = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Vital_Weight" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_vital_weight
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_vital_weight, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_vital_weight = NumberUtil.Val( value, ".");
         }

      }

      public SdtBR_Vital sdt
      {
         get {
            return (SdtBR_Vital)Sdt ;
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
            sdt = new SdtBR_Vital() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 12 )]
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
