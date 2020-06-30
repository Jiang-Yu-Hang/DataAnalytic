/*
               File: type_SdtBR_Information
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:28.3
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
   [XmlRoot(ElementName = "BR_Information" )]
   [XmlType(TypeName =  "BR_Information" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Information : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Information( )
      {
      }

      public SdtBR_Information( IGxContext context )
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

      public void Load( long AV85BR_Information_ID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV85BR_Information_ID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Information_ID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Information");
         metadata.Set("BT", "BR_Information");
         metadata.Set("PK", "[ \"BR_Information_ID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Information_ID\" ]");
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
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_information_birthdate_Z_Nullable");
         state.Add("gxTpr_Br_information_crtuser_Z");
         state.Add("gxTpr_Br_information_crtdate_Z_Nullable");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_information_birthdate_N");
         state.Add("gxTpr_Br_information_crtuser_N");
         state.Add("gxTpr_Br_information_crtdate_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Information sdt ;
         sdt = (SdtBR_Information)(source);
         gxTv_SdtBR_Information_Br_information_id = sdt.gxTv_SdtBR_Information_Br_information_id ;
         gxTv_SdtBR_Information_Br_information_patientno = sdt.gxTv_SdtBR_Information_Br_information_patientno ;
         gxTv_SdtBR_Information_Br_information_birthdate = sdt.gxTv_SdtBR_Information_Br_information_birthdate ;
         gxTv_SdtBR_Information_Br_information_crtuser = sdt.gxTv_SdtBR_Information_Br_information_crtuser ;
         gxTv_SdtBR_Information_Br_information_crtdate = sdt.gxTv_SdtBR_Information_Br_information_crtdate ;
         gxTv_SdtBR_Information_Mode = sdt.gxTv_SdtBR_Information_Mode ;
         gxTv_SdtBR_Information_Initialized = sdt.gxTv_SdtBR_Information_Initialized ;
         gxTv_SdtBR_Information_Br_information_id_Z = sdt.gxTv_SdtBR_Information_Br_information_id_Z ;
         gxTv_SdtBR_Information_Br_information_patientno_Z = sdt.gxTv_SdtBR_Information_Br_information_patientno_Z ;
         gxTv_SdtBR_Information_Br_information_birthdate_Z = sdt.gxTv_SdtBR_Information_Br_information_birthdate_Z ;
         gxTv_SdtBR_Information_Br_information_crtuser_Z = sdt.gxTv_SdtBR_Information_Br_information_crtuser_Z ;
         gxTv_SdtBR_Information_Br_information_crtdate_Z = sdt.gxTv_SdtBR_Information_Br_information_crtdate_Z ;
         gxTv_SdtBR_Information_Br_information_patientno_N = sdt.gxTv_SdtBR_Information_Br_information_patientno_N ;
         gxTv_SdtBR_Information_Br_information_birthdate_N = sdt.gxTv_SdtBR_Information_Br_information_birthdate_N ;
         gxTv_SdtBR_Information_Br_information_crtuser_N = sdt.gxTv_SdtBR_Information_Br_information_crtuser_N ;
         gxTv_SdtBR_Information_Br_information_crtdate_N = sdt.gxTv_SdtBR_Information_Br_information_crtdate_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Information_Br_information_id), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Information_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Information_Br_information_patientno_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Information_Br_information_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Information_Br_information_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Information_Br_information_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Information_BirthDate", sDateCnv, false);
         AddObjectProperty("BR_Information_BirthDate_N", gxTv_SdtBR_Information_Br_information_birthdate_N, false);
         AddObjectProperty("BR_Information_CrtUser", gxTv_SdtBR_Information_Br_information_crtuser, false);
         AddObjectProperty("BR_Information_CrtUser_N", gxTv_SdtBR_Information_Br_information_crtuser_N, false);
         datetime_STZ = gxTv_SdtBR_Information_Br_information_crtdate;
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
         AddObjectProperty("BR_Information_CrtDate", sDateCnv, false);
         AddObjectProperty("BR_Information_CrtDate_N", gxTv_SdtBR_Information_Br_information_crtdate_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Information_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Information_Initialized, false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Information_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Information_Br_information_patientno_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Information_Br_information_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Information_Br_information_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Information_Br_information_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Information_BirthDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Information_CrtUser_Z", gxTv_SdtBR_Information_Br_information_crtuser_Z, false);
            datetime_STZ = gxTv_SdtBR_Information_Br_information_crtdate_Z;
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
            AddObjectProperty("BR_Information_CrtDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Information_Br_information_patientno_N, false);
            AddObjectProperty("BR_Information_BirthDate_N", gxTv_SdtBR_Information_Br_information_birthdate_N, false);
            AddObjectProperty("BR_Information_CrtUser_N", gxTv_SdtBR_Information_Br_information_crtuser_N, false);
            AddObjectProperty("BR_Information_CrtDate_N", gxTv_SdtBR_Information_Br_information_crtdate_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Information sdt )
      {
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtBR_Information_Br_information_id = sdt.gxTv_SdtBR_Information_Br_information_id ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Information_Br_information_patientno = sdt.gxTv_SdtBR_Information_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Information_BirthDate") )
         {
            gxTv_SdtBR_Information_Br_information_birthdate = sdt.gxTv_SdtBR_Information_Br_information_birthdate ;
         }
         if ( sdt.IsDirty("BR_Information_CrtUser") )
         {
            gxTv_SdtBR_Information_Br_information_crtuser = sdt.gxTv_SdtBR_Information_Br_information_crtuser ;
         }
         if ( sdt.IsDirty("BR_Information_CrtDate") )
         {
            gxTv_SdtBR_Information_Br_information_crtdate = sdt.gxTv_SdtBR_Information_Br_information_crtdate ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtBR_Information_Br_information_id ;
         }

         set {
            if ( gxTv_SdtBR_Information_Br_information_id != value )
            {
               gxTv_SdtBR_Information_Mode = "INS";
               this.gxTv_SdtBR_Information_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_Information_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Information_Br_information_birthdate_Z_SetNull( );
               this.gxTv_SdtBR_Information_Br_information_crtuser_Z_SetNull( );
               this.gxTv_SdtBR_Information_Br_information_crtdate_Z_SetNull( );
            }
            gxTv_SdtBR_Information_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Information_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_patientno_N = 0;
            gxTv_SdtBR_Information_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_patientno_N = 1;
         gxTv_SdtBR_Information_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_BirthDate" )]
      [  XmlElement( ElementName = "BR_Information_BirthDate"  , IsNullable=true )]
      public string gxTpr_Br_information_birthdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Information_Br_information_birthdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Information_Br_information_birthdate).value ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_birthdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Information_Br_information_birthdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Information_Br_information_birthdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_information_birthdate
      {
         get {
            return gxTv_SdtBR_Information_Br_information_birthdate ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_birthdate_N = 0;
            gxTv_SdtBR_Information_Br_information_birthdate = value;
            SetDirty("Br_information_birthdate");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_birthdate_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_birthdate_N = 1;
         gxTv_SdtBR_Information_Br_information_birthdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_birthdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtUser" )]
      [  XmlElement( ElementName = "BR_Information_CrtUser"   )]
      public String gxTpr_Br_information_crtuser
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtuser ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtuser_N = 0;
            gxTv_SdtBR_Information_Br_information_crtuser = value;
            SetDirty("Br_information_crtuser");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtuser_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtuser_N = 1;
         gxTv_SdtBR_Information_Br_information_crtuser = "";
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtuser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtDate" )]
      [  XmlElement( ElementName = "BR_Information_CrtDate"  , IsNullable=true )]
      public string gxTpr_Br_information_crtdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Information_Br_information_crtdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Information_Br_information_crtdate).value ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Information_Br_information_crtdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Information_Br_information_crtdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_information_crtdate
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtdate ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtdate_N = 0;
            gxTv_SdtBR_Information_Br_information_crtdate = value;
            SetDirty("Br_information_crtdate");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtdate_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtdate_N = 1;
         gxTv_SdtBR_Information_Br_information_crtdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Information_Mode ;
         }

         set {
            gxTv_SdtBR_Information_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Information_Mode_SetNull( )
      {
         gxTv_SdtBR_Information_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Information_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Information_Initialized ;
         }

         set {
            gxTv_SdtBR_Information_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Information_Initialized_SetNull( )
      {
         gxTv_SdtBR_Information_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtBR_Information_Br_information_id_Z ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Information_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_BirthDate_Z" )]
      [  XmlElement( ElementName = "BR_Information_BirthDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_information_birthdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Information_Br_information_birthdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Information_Br_information_birthdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Information_Br_information_birthdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Information_Br_information_birthdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_information_birthdate_Z
      {
         get {
            return gxTv_SdtBR_Information_Br_information_birthdate_Z ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_birthdate_Z = value;
            SetDirty("Br_information_birthdate_Z");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_birthdate_Z_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_birthdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_birthdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtUser_Z" )]
      [  XmlElement( ElementName = "BR_Information_CrtUser_Z"   )]
      public String gxTpr_Br_information_crtuser_Z
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtuser_Z ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtuser_Z = value;
            SetDirty("Br_information_crtuser_Z");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtuser_Z_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtuser_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtuser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtDate_Z" )]
      [  XmlElement( ElementName = "BR_Information_CrtDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_information_crtdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Information_Br_information_crtdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Information_Br_information_crtdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Information_Br_information_crtdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Information_Br_information_crtdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_information_crtdate_Z
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtdate_Z ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtdate_Z = value;
            SetDirty("Br_information_crtdate_Z");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtdate_Z_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Information_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_BirthDate_N" )]
      [  XmlElement( ElementName = "BR_Information_BirthDate_N"   )]
      public short gxTpr_Br_information_birthdate_N
      {
         get {
            return gxTv_SdtBR_Information_Br_information_birthdate_N ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_birthdate_N = value;
            SetDirty("Br_information_birthdate_N");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_birthdate_N_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_birthdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_birthdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtUser_N" )]
      [  XmlElement( ElementName = "BR_Information_CrtUser_N"   )]
      public short gxTpr_Br_information_crtuser_N
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtuser_N ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtuser_N = value;
            SetDirty("Br_information_crtuser_N");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtuser_N_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtuser_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtuser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_CrtDate_N" )]
      [  XmlElement( ElementName = "BR_Information_CrtDate_N"   )]
      public short gxTpr_Br_information_crtdate_N
      {
         get {
            return gxTv_SdtBR_Information_Br_information_crtdate_N ;
         }

         set {
            gxTv_SdtBR_Information_Br_information_crtdate_N = value;
            SetDirty("Br_information_crtdate_N");
         }

      }

      public void gxTv_SdtBR_Information_Br_information_crtdate_N_SetNull( )
      {
         gxTv_SdtBR_Information_Br_information_crtdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Information_Br_information_crtdate_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Information_Br_information_patientno = "";
         gxTv_SdtBR_Information_Br_information_birthdate = DateTime.MinValue;
         gxTv_SdtBR_Information_Br_information_crtuser = "";
         gxTv_SdtBR_Information_Br_information_crtdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Information_Mode = "";
         gxTv_SdtBR_Information_Br_information_patientno_Z = "";
         gxTv_SdtBR_Information_Br_information_birthdate_Z = DateTime.MinValue;
         gxTv_SdtBR_Information_Br_information_crtuser_Z = "";
         gxTv_SdtBR_Information_Br_information_crtdate_Z = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_information", "GeneXus.Programs.br_information_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Information_Initialized ;
      private short gxTv_SdtBR_Information_Br_information_patientno_N ;
      private short gxTv_SdtBR_Information_Br_information_birthdate_N ;
      private short gxTv_SdtBR_Information_Br_information_crtuser_N ;
      private short gxTv_SdtBR_Information_Br_information_crtdate_N ;
      private long gxTv_SdtBR_Information_Br_information_id ;
      private long gxTv_SdtBR_Information_Br_information_id_Z ;
      private String gxTv_SdtBR_Information_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Information_Br_information_crtdate ;
      private DateTime gxTv_SdtBR_Information_Br_information_crtdate_Z ;
      private DateTime datetime_STZ ;
      private DateTime gxTv_SdtBR_Information_Br_information_birthdate ;
      private DateTime gxTv_SdtBR_Information_Br_information_birthdate_Z ;
      private String gxTv_SdtBR_Information_Br_information_patientno ;
      private String gxTv_SdtBR_Information_Br_information_crtuser ;
      private String gxTv_SdtBR_Information_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Information_Br_information_crtuser_Z ;
   }

   [DataContract(Name = @"BR_Information", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Information_RESTInterface : GxGenericCollectionItem<SdtBR_Information>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Information_RESTInterface( ) : base()
      {
      }

      public SdtBR_Information_RESTInterface( SdtBR_Information psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Information_ID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_information_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_information_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_information_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 1 )]
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

      [DataMember( Name = "BR_Information_BirthDate" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_information_birthdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_information_birthdate) ;
         }

         set {
            sdt.gxTpr_Br_information_birthdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Information_CrtUser" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_information_crtuser
      {
         get {
            return sdt.gxTpr_Br_information_crtuser ;
         }

         set {
            sdt.gxTpr_Br_information_crtuser = value;
         }

      }

      [DataMember( Name = "BR_Information_CrtDate" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_information_crtdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_information_crtdate) ;
         }

         set {
            sdt.gxTpr_Br_information_crtdate = DateTimeUtil.CToT2( value);
         }

      }

      public SdtBR_Information sdt
      {
         get {
            return (SdtBR_Information)Sdt ;
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
            sdt = new SdtBR_Information() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 5 )]
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
