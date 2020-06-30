/*
               File: type_Sdtview_lastest_patient_info
        Description: view_lastest_patient_info
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:7.13
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
   [XmlRoot(ElementName = "view_lastest_patient_info" )]
   [XmlType(TypeName =  "view_lastest_patient_info" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class Sdtview_lastest_patient_info : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtview_lastest_patient_info( )
      {
      }

      public Sdtview_lastest_patient_info( IGxContext context )
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

      public void Load( long AV520VIEW_LPI_BR_Information_ID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV520VIEW_LPI_BR_Information_ID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"VIEW_LPI_BR_Information_ID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "view_lastest_patient_info");
         metadata.Set("BT", "VIEW_LASTEST_PATIENT_INFO");
         metadata.Set("PK", "[ \"VIEW_LPI_BR_Information_ID\" ]");
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
         state.Add("gxTpr_View_lpi_br_information_id_Z");
         state.Add("gxTpr_View_lpi_br_information_patientno_Z");
         state.Add("gxTpr_View_lpi_br_encounter_admitdate_Z_Nullable");
         state.Add("gxTpr_View_lpi_br_demographics_sex_Z");
         state.Add("gxTpr_View_lpi_br_demographics_birthdate_Z_Nullable");
         state.Add("gxTpr_View_lpi_br_demographics_ethnic_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         Sdtview_lastest_patient_info sdt ;
         sdt = (Sdtview_lastest_patient_info)(source);
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic ;
         gxTv_Sdtview_lastest_patient_info_Mode = sdt.gxTv_Sdtview_lastest_patient_info_Mode ;
         gxTv_Sdtview_lastest_patient_info_Initialized = sdt.gxTv_Sdtview_lastest_patient_info_Initialized ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z ;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("VIEW_LPI_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id), 18, 0)), false);
         AddObjectProperty("VIEW_LPI_BR_Information_PatientNo", gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno, false);
         datetime_STZ = gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("VIEW_LPI_BR_Encounter_AdmitDate", sDateCnv, false);
         AddObjectProperty("VIEW_LPI_BR_Demographics_Sex", gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("VIEW_LPI_BR_Demographics_BirthDate", sDateCnv, false);
         AddObjectProperty("VIEW_LPI_BR_Demographics_Ethnic", gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtview_lastest_patient_info_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtview_lastest_patient_info_Initialized, false);
            AddObjectProperty("VIEW_LPI_BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z), 18, 0)), false);
            AddObjectProperty("VIEW_LPI_BR_Information_PatientNo_Z", gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z, false);
            datetime_STZ = gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("VIEW_LPI_BR_Encounter_AdmitDate_Z", sDateCnv, false);
            AddObjectProperty("VIEW_LPI_BR_Demographics_Sex_Z", gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("VIEW_LPI_BR_Demographics_BirthDate_Z", sDateCnv, false);
            AddObjectProperty("VIEW_LPI_BR_Demographics_Ethnic_Z", gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( Sdtview_lastest_patient_info sdt )
      {
         if ( sdt.IsDirty("VIEW_LPI_BR_Information_ID") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id ;
         }
         if ( sdt.IsDirty("VIEW_LPI_BR_Information_PatientNo") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno ;
         }
         if ( sdt.IsDirty("VIEW_LPI_BR_Encounter_AdmitDate") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate ;
         }
         if ( sdt.IsDirty("VIEW_LPI_BR_Demographics_Sex") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex ;
         }
         if ( sdt.IsDirty("VIEW_LPI_BR_Demographics_BirthDate") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate ;
         }
         if ( sdt.IsDirty("VIEW_LPI_BR_Demographics_Ethnic") )
         {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic = sdt.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Information_ID" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Information_ID"   )]
      public long gxTpr_View_lpi_br_information_id
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id ;
         }

         set {
            if ( gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id != value )
            {
               gxTv_Sdtview_lastest_patient_info_Mode = "INS";
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z_SetNull( );
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z_SetNull( );
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z_SetNull( );
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z_SetNull( );
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z_SetNull( );
               this.gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z_SetNull( );
            }
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id = value;
            SetDirty("View_lpi_br_information_id");
         }

      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Information_PatientNo"   )]
      public String gxTpr_View_lpi_br_information_patientno
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno = value;
            SetDirty("View_lpi_br_information_patientno");
         }

      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Encounter_AdmitDate" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Encounter_AdmitDate"  , IsNullable=true )]
      public string gxTpr_View_lpi_br_encounter_admitdate_Nullable
      {
         get {
            if ( gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = DateTime.MinValue;
            else
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_lpi_br_encounter_admitdate
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = value;
            SetDirty("View_lpi_br_encounter_admitdate");
         }

      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_Sex" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_Sex"   )]
      public String gxTpr_View_lpi_br_demographics_sex
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex = value;
            SetDirty("View_lpi_br_demographics_sex");
         }

      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_BirthDate" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_BirthDate"  , IsNullable=true )]
      public string gxTpr_View_lpi_br_demographics_birthdate_Nullable
      {
         get {
            if ( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = DateTime.MinValue;
            else
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_lpi_br_demographics_birthdate
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = value;
            SetDirty("View_lpi_br_demographics_birthdate");
         }

      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_Ethnic" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_Ethnic"   )]
      public String gxTpr_View_lpi_br_demographics_ethnic
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic = value;
            SetDirty("View_lpi_br_demographics_ethnic");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_Mode ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_Mode_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_Initialized ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_Initialized_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Information_ID_Z"   )]
      public long gxTpr_View_lpi_br_information_id_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z = value;
            SetDirty("View_lpi_br_information_id_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Information_PatientNo_Z"   )]
      public String gxTpr_View_lpi_br_information_patientno_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z = value;
            SetDirty("View_lpi_br_information_patientno_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Encounter_AdmitDate_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Encounter_AdmitDate_Z"  , IsNullable=true )]
      public string gxTpr_View_lpi_br_encounter_admitdate_Z_Nullable
      {
         get {
            if ( gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = DateTime.MinValue;
            else
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_lpi_br_encounter_admitdate_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = value;
            SetDirty("View_lpi_br_encounter_admitdate_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_Sex_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_Sex_Z"   )]
      public String gxTpr_View_lpi_br_demographics_sex_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z = value;
            SetDirty("View_lpi_br_demographics_sex_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z = "";
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_BirthDate_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_BirthDate_Z"  , IsNullable=true )]
      public string gxTpr_View_lpi_br_demographics_birthdate_Z_Nullable
      {
         get {
            if ( gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = DateTime.MinValue;
            else
               gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_View_lpi_br_demographics_birthdate_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = value;
            SetDirty("View_lpi_br_demographics_birthdate_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "VIEW_LPI_BR_Demographics_Ethnic_Z" )]
      [  XmlElement( ElementName = "VIEW_LPI_BR_Demographics_Ethnic_Z"   )]
      public String gxTpr_View_lpi_br_demographics_ethnic_Z
      {
         get {
            return gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z ;
         }

         set {
            gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z = value;
            SetDirty("View_lpi_br_demographics_ethnic_Z");
         }

      }

      public void gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z_SetNull( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z = "";
         return  ;
      }

      public bool gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno = "";
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate = (DateTime)(DateTime.MinValue);
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex = "";
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate = DateTime.MinValue;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic = "";
         gxTv_Sdtview_lastest_patient_info_Mode = "";
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z = "";
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z = "";
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z = DateTime.MinValue;
         gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "view_lastest_patient_info", "GeneXus.Programs.view_lastest_patient_info_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtview_lastest_patient_info_Initialized ;
      private long gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id ;
      private long gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_id_Z ;
      private String gxTv_Sdtview_lastest_patient_info_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate ;
      private DateTime gxTv_Sdtview_lastest_patient_info_View_lpi_br_encounter_admitdate_Z ;
      private DateTime datetime_STZ ;
      private DateTime gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate ;
      private DateTime gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_birthdate_Z ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_information_patientno_Z ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_sex_Z ;
      private String gxTv_Sdtview_lastest_patient_info_View_lpi_br_demographics_ethnic_Z ;
   }

   [DataContract(Name = @"view_lastest_patient_info", Namespace = "DataAnalysisPlatform")]
   public class Sdtview_lastest_patient_info_RESTInterface : GxGenericCollectionItem<Sdtview_lastest_patient_info>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtview_lastest_patient_info_RESTInterface( ) : base()
      {
      }

      public Sdtview_lastest_patient_info_RESTInterface( Sdtview_lastest_patient_info psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "VIEW_LPI_BR_Information_ID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_information_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_View_lpi_br_information_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_View_lpi_br_information_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "VIEW_LPI_BR_Information_PatientNo" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_information_patientno
      {
         get {
            return sdt.gxTpr_View_lpi_br_information_patientno ;
         }

         set {
            sdt.gxTpr_View_lpi_br_information_patientno = value;
         }

      }

      [DataMember( Name = "VIEW_LPI_BR_Encounter_AdmitDate" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_encounter_admitdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_View_lpi_br_encounter_admitdate) ;
         }

         set {
            sdt.gxTpr_View_lpi_br_encounter_admitdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "VIEW_LPI_BR_Demographics_Sex" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_demographics_sex
      {
         get {
            return sdt.gxTpr_View_lpi_br_demographics_sex ;
         }

         set {
            sdt.gxTpr_View_lpi_br_demographics_sex = value;
         }

      }

      [DataMember( Name = "VIEW_LPI_BR_Demographics_BirthDate" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_demographics_birthdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_View_lpi_br_demographics_birthdate) ;
         }

         set {
            sdt.gxTpr_View_lpi_br_demographics_birthdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "VIEW_LPI_BR_Demographics_Ethnic" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_View_lpi_br_demographics_ethnic
      {
         get {
            return sdt.gxTpr_View_lpi_br_demographics_ethnic ;
         }

         set {
            sdt.gxTpr_View_lpi_br_demographics_ethnic = value;
         }

      }

      public Sdtview_lastest_patient_info sdt
      {
         get {
            return (Sdtview_lastest_patient_info)Sdt ;
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
            sdt = new Sdtview_lastest_patient_info() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
