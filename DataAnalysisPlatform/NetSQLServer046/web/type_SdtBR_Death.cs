/*
               File: type_SdtBR_Death
        Description: 死亡情况
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 13:24:2.15
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
   [XmlRoot(ElementName = "BR_Death" )]
   [XmlType(TypeName =  "BR_Death" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Death : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Death( )
      {
      }

      public SdtBR_Death( IGxContext context )
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

      public void Load( long AV48BR_DeathID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV48BR_DeathID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_DeathID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Death");
         metadata.Set("BT", "BR_Death");
         metadata.Set("PK", "[ \"BR_DeathID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_DeathID\" ]");
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
         state.Add("gxTpr_Br_deathid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_death_date_Z_Nullable");
         state.Add("gxTpr_Br_death_cause_Z");
         state.Add("gxTpr_Br_death_causecode_Z");
         state.Add("gxTpr_Br_death_causecode_code_Z");
         state.Add("gxTpr_Br_death_sourse_Z");
         state.Add("gxTpr_Br_death_sourse_code_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_death_date_N");
         state.Add("gxTpr_Br_death_cause_N");
         state.Add("gxTpr_Br_death_causecode_N");
         state.Add("gxTpr_Br_death_causecode_code_N");
         state.Add("gxTpr_Br_death_sourse_N");
         state.Add("gxTpr_Br_death_sourse_code_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Death sdt ;
         sdt = (SdtBR_Death)(source);
         gxTv_SdtBR_Death_Br_deathid = sdt.gxTv_SdtBR_Death_Br_deathid ;
         gxTv_SdtBR_Death_Br_encounterid = sdt.gxTv_SdtBR_Death_Br_encounterid ;
         gxTv_SdtBR_Death_Br_information_patientno = sdt.gxTv_SdtBR_Death_Br_information_patientno ;
         gxTv_SdtBR_Death_Br_death_date = sdt.gxTv_SdtBR_Death_Br_death_date ;
         gxTv_SdtBR_Death_Br_death_cause = sdt.gxTv_SdtBR_Death_Br_death_cause ;
         gxTv_SdtBR_Death_Br_death_causecode = sdt.gxTv_SdtBR_Death_Br_death_causecode ;
         gxTv_SdtBR_Death_Br_death_causecode_code = sdt.gxTv_SdtBR_Death_Br_death_causecode_code ;
         gxTv_SdtBR_Death_Br_death_sourse = sdt.gxTv_SdtBR_Death_Br_death_sourse ;
         gxTv_SdtBR_Death_Br_death_sourse_code = sdt.gxTv_SdtBR_Death_Br_death_sourse_code ;
         gxTv_SdtBR_Death_Mode = sdt.gxTv_SdtBR_Death_Mode ;
         gxTv_SdtBR_Death_Initialized = sdt.gxTv_SdtBR_Death_Initialized ;
         gxTv_SdtBR_Death_Br_deathid_Z = sdt.gxTv_SdtBR_Death_Br_deathid_Z ;
         gxTv_SdtBR_Death_Br_encounterid_Z = sdt.gxTv_SdtBR_Death_Br_encounterid_Z ;
         gxTv_SdtBR_Death_Br_information_patientno_Z = sdt.gxTv_SdtBR_Death_Br_information_patientno_Z ;
         gxTv_SdtBR_Death_Br_death_date_Z = sdt.gxTv_SdtBR_Death_Br_death_date_Z ;
         gxTv_SdtBR_Death_Br_death_cause_Z = sdt.gxTv_SdtBR_Death_Br_death_cause_Z ;
         gxTv_SdtBR_Death_Br_death_causecode_Z = sdt.gxTv_SdtBR_Death_Br_death_causecode_Z ;
         gxTv_SdtBR_Death_Br_death_causecode_code_Z = sdt.gxTv_SdtBR_Death_Br_death_causecode_code_Z ;
         gxTv_SdtBR_Death_Br_death_sourse_Z = sdt.gxTv_SdtBR_Death_Br_death_sourse_Z ;
         gxTv_SdtBR_Death_Br_death_sourse_code_Z = sdt.gxTv_SdtBR_Death_Br_death_sourse_code_Z ;
         gxTv_SdtBR_Death_Br_information_patientno_N = sdt.gxTv_SdtBR_Death_Br_information_patientno_N ;
         gxTv_SdtBR_Death_Br_death_date_N = sdt.gxTv_SdtBR_Death_Br_death_date_N ;
         gxTv_SdtBR_Death_Br_death_cause_N = sdt.gxTv_SdtBR_Death_Br_death_cause_N ;
         gxTv_SdtBR_Death_Br_death_causecode_N = sdt.gxTv_SdtBR_Death_Br_death_causecode_N ;
         gxTv_SdtBR_Death_Br_death_causecode_code_N = sdt.gxTv_SdtBR_Death_Br_death_causecode_code_N ;
         gxTv_SdtBR_Death_Br_death_sourse_N = sdt.gxTv_SdtBR_Death_Br_death_sourse_N ;
         gxTv_SdtBR_Death_Br_death_sourse_code_N = sdt.gxTv_SdtBR_Death_Br_death_sourse_code_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Death_Br_deathid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Death_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Death_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Death_Br_information_patientno_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Death_Br_death_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Death_Br_death_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Death_Br_death_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Death_Date", sDateCnv, false);
         AddObjectProperty("BR_Death_Date_N", gxTv_SdtBR_Death_Br_death_date_N, false);
         AddObjectProperty("BR_Death_Cause", gxTv_SdtBR_Death_Br_death_cause, false);
         AddObjectProperty("BR_Death_Cause_N", gxTv_SdtBR_Death_Br_death_cause_N, false);
         AddObjectProperty("BR_Death_CauseCode", gxTv_SdtBR_Death_Br_death_causecode, false);
         AddObjectProperty("BR_Death_CauseCode_N", gxTv_SdtBR_Death_Br_death_causecode_N, false);
         AddObjectProperty("BR_Death_CauseCode_Code", gxTv_SdtBR_Death_Br_death_causecode_code, false);
         AddObjectProperty("BR_Death_CauseCode_Code_N", gxTv_SdtBR_Death_Br_death_causecode_code_N, false);
         AddObjectProperty("BR_Death_Sourse", gxTv_SdtBR_Death_Br_death_sourse, false);
         AddObjectProperty("BR_Death_Sourse_N", gxTv_SdtBR_Death_Br_death_sourse_N, false);
         AddObjectProperty("BR_Death_Sourse_Code", gxTv_SdtBR_Death_Br_death_sourse_code, false);
         AddObjectProperty("BR_Death_Sourse_Code_N", gxTv_SdtBR_Death_Br_death_sourse_code_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Death_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Death_Initialized, false);
            AddObjectProperty("BR_DeathID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Death_Br_deathid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Death_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Death_Br_information_patientno_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Death_Br_death_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Death_Br_death_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Death_Br_death_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Death_Date_Z", sDateCnv, false);
            AddObjectProperty("BR_Death_Cause_Z", gxTv_SdtBR_Death_Br_death_cause_Z, false);
            AddObjectProperty("BR_Death_CauseCode_Z", gxTv_SdtBR_Death_Br_death_causecode_Z, false);
            AddObjectProperty("BR_Death_CauseCode_Code_Z", gxTv_SdtBR_Death_Br_death_causecode_code_Z, false);
            AddObjectProperty("BR_Death_Sourse_Z", gxTv_SdtBR_Death_Br_death_sourse_Z, false);
            AddObjectProperty("BR_Death_Sourse_Code_Z", gxTv_SdtBR_Death_Br_death_sourse_code_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Death_Br_information_patientno_N, false);
            AddObjectProperty("BR_Death_Date_N", gxTv_SdtBR_Death_Br_death_date_N, false);
            AddObjectProperty("BR_Death_Cause_N", gxTv_SdtBR_Death_Br_death_cause_N, false);
            AddObjectProperty("BR_Death_CauseCode_N", gxTv_SdtBR_Death_Br_death_causecode_N, false);
            AddObjectProperty("BR_Death_CauseCode_Code_N", gxTv_SdtBR_Death_Br_death_causecode_code_N, false);
            AddObjectProperty("BR_Death_Sourse_N", gxTv_SdtBR_Death_Br_death_sourse_N, false);
            AddObjectProperty("BR_Death_Sourse_Code_N", gxTv_SdtBR_Death_Br_death_sourse_code_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Death sdt )
      {
         if ( sdt.IsDirty("BR_DeathID") )
         {
            gxTv_SdtBR_Death_Br_deathid = sdt.gxTv_SdtBR_Death_Br_deathid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Death_Br_encounterid = sdt.gxTv_SdtBR_Death_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Death_Br_information_patientno = sdt.gxTv_SdtBR_Death_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Death_Date") )
         {
            gxTv_SdtBR_Death_Br_death_date = sdt.gxTv_SdtBR_Death_Br_death_date ;
         }
         if ( sdt.IsDirty("BR_Death_Cause") )
         {
            gxTv_SdtBR_Death_Br_death_cause = sdt.gxTv_SdtBR_Death_Br_death_cause ;
         }
         if ( sdt.IsDirty("BR_Death_CauseCode") )
         {
            gxTv_SdtBR_Death_Br_death_causecode = sdt.gxTv_SdtBR_Death_Br_death_causecode ;
         }
         if ( sdt.IsDirty("BR_Death_CauseCode_Code") )
         {
            gxTv_SdtBR_Death_Br_death_causecode_code = sdt.gxTv_SdtBR_Death_Br_death_causecode_code ;
         }
         if ( sdt.IsDirty("BR_Death_Sourse") )
         {
            gxTv_SdtBR_Death_Br_death_sourse = sdt.gxTv_SdtBR_Death_Br_death_sourse ;
         }
         if ( sdt.IsDirty("BR_Death_Sourse_Code") )
         {
            gxTv_SdtBR_Death_Br_death_sourse_code = sdt.gxTv_SdtBR_Death_Br_death_sourse_code ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_DeathID" )]
      [  XmlElement( ElementName = "BR_DeathID"   )]
      public long gxTpr_Br_deathid
      {
         get {
            return gxTv_SdtBR_Death_Br_deathid ;
         }

         set {
            if ( gxTv_SdtBR_Death_Br_deathid != value )
            {
               gxTv_SdtBR_Death_Mode = "INS";
               this.gxTv_SdtBR_Death_Br_deathid_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_date_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_cause_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_causecode_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_causecode_code_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_sourse_Z_SetNull( );
               this.gxTv_SdtBR_Death_Br_death_sourse_code_Z_SetNull( );
            }
            gxTv_SdtBR_Death_Br_deathid = value;
            SetDirty("Br_deathid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Death_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Death_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Death_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Death_Br_information_patientno_N = 0;
            gxTv_SdtBR_Death_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Death_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Death_Br_information_patientno_N = 1;
         gxTv_SdtBR_Death_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Date" )]
      [  XmlElement( ElementName = "BR_Death_Date"  , IsNullable=true )]
      public string gxTpr_Br_death_date_Nullable
      {
         get {
            if ( gxTv_SdtBR_Death_Br_death_date == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Death_Br_death_date).value ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_date_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Death_Br_death_date = DateTime.MinValue;
            else
               gxTv_SdtBR_Death_Br_death_date = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_death_date
      {
         get {
            return gxTv_SdtBR_Death_Br_death_date ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_date_N = 0;
            gxTv_SdtBR_Death_Br_death_date = value;
            SetDirty("Br_death_date");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_date_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_date_N = 1;
         gxTv_SdtBR_Death_Br_death_date = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_date_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Cause" )]
      [  XmlElement( ElementName = "BR_Death_Cause"   )]
      public String gxTpr_Br_death_cause
      {
         get {
            return gxTv_SdtBR_Death_Br_death_cause ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_cause_N = 0;
            gxTv_SdtBR_Death_Br_death_cause = value;
            SetDirty("Br_death_cause");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_cause_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_cause_N = 1;
         gxTv_SdtBR_Death_Br_death_cause = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_cause_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode"   )]
      public String gxTpr_Br_death_causecode
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_N = 0;
            gxTv_SdtBR_Death_Br_death_causecode = value;
            SetDirty("Br_death_causecode");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_N = 1;
         gxTv_SdtBR_Death_Br_death_causecode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode_Code" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode_Code"   )]
      public String gxTpr_Br_death_causecode_code
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode_code ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_code_N = 0;
            gxTv_SdtBR_Death_Br_death_causecode_code = value;
            SetDirty("Br_death_causecode_code");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_code_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_code_N = 1;
         gxTv_SdtBR_Death_Br_death_causecode_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse" )]
      [  XmlElement( ElementName = "BR_Death_Sourse"   )]
      public String gxTpr_Br_death_sourse
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_N = 0;
            gxTv_SdtBR_Death_Br_death_sourse = value;
            SetDirty("Br_death_sourse");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_N = 1;
         gxTv_SdtBR_Death_Br_death_sourse = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse_Code" )]
      [  XmlElement( ElementName = "BR_Death_Sourse_Code"   )]
      public String gxTpr_Br_death_sourse_code
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse_code ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_code_N = 0;
            gxTv_SdtBR_Death_Br_death_sourse_code = value;
            SetDirty("Br_death_sourse_code");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_code_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_code_N = 1;
         gxTv_SdtBR_Death_Br_death_sourse_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Death_Mode ;
         }

         set {
            gxTv_SdtBR_Death_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Death_Mode_SetNull( )
      {
         gxTv_SdtBR_Death_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Death_Initialized ;
         }

         set {
            gxTv_SdtBR_Death_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Death_Initialized_SetNull( )
      {
         gxTv_SdtBR_Death_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_DeathID_Z" )]
      [  XmlElement( ElementName = "BR_DeathID_Z"   )]
      public long gxTpr_Br_deathid_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_deathid_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_deathid_Z = value;
            SetDirty("Br_deathid_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_deathid_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_deathid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_deathid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Date_Z" )]
      [  XmlElement( ElementName = "BR_Death_Date_Z"  , IsNullable=true )]
      public string gxTpr_Br_death_date_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Death_Br_death_date_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Death_Br_death_date_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Death_Br_death_date_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Death_Br_death_date_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_death_date_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_date_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_date_Z = value;
            SetDirty("Br_death_date_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_date_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_date_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_date_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Cause_Z" )]
      [  XmlElement( ElementName = "BR_Death_Cause_Z"   )]
      public String gxTpr_Br_death_cause_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_cause_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_cause_Z = value;
            SetDirty("Br_death_cause_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_cause_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_cause_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_cause_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode_Z" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode_Z"   )]
      public String gxTpr_Br_death_causecode_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_Z = value;
            SetDirty("Br_death_causecode_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode_Code_Z" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode_Code_Z"   )]
      public String gxTpr_Br_death_causecode_code_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode_code_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_code_Z = value;
            SetDirty("Br_death_causecode_code_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_code_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse_Z" )]
      [  XmlElement( ElementName = "BR_Death_Sourse_Z"   )]
      public String gxTpr_Br_death_sourse_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_Z = value;
            SetDirty("Br_death_sourse_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse_Code_Z" )]
      [  XmlElement( ElementName = "BR_Death_Sourse_Code_Z"   )]
      public String gxTpr_Br_death_sourse_code_Z
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse_code_Z ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_code_Z = value;
            SetDirty("Br_death_sourse_code_Z");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_code_Z_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Death_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Date_N" )]
      [  XmlElement( ElementName = "BR_Death_Date_N"   )]
      public short gxTpr_Br_death_date_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_date_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_date_N = value;
            SetDirty("Br_death_date_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_date_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_date_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_date_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Cause_N" )]
      [  XmlElement( ElementName = "BR_Death_Cause_N"   )]
      public short gxTpr_Br_death_cause_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_cause_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_cause_N = value;
            SetDirty("Br_death_cause_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_cause_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_cause_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_cause_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode_N" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode_N"   )]
      public short gxTpr_Br_death_causecode_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_N = value;
            SetDirty("Br_death_causecode_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_CauseCode_Code_N" )]
      [  XmlElement( ElementName = "BR_Death_CauseCode_Code_N"   )]
      public short gxTpr_Br_death_causecode_code_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_causecode_code_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_causecode_code_N = value;
            SetDirty("Br_death_causecode_code_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_causecode_code_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_causecode_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_causecode_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse_N" )]
      [  XmlElement( ElementName = "BR_Death_Sourse_N"   )]
      public short gxTpr_Br_death_sourse_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_N = value;
            SetDirty("Br_death_sourse_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Death_Sourse_Code_N" )]
      [  XmlElement( ElementName = "BR_Death_Sourse_Code_N"   )]
      public short gxTpr_Br_death_sourse_code_N
      {
         get {
            return gxTv_SdtBR_Death_Br_death_sourse_code_N ;
         }

         set {
            gxTv_SdtBR_Death_Br_death_sourse_code_N = value;
            SetDirty("Br_death_sourse_code_N");
         }

      }

      public void gxTv_SdtBR_Death_Br_death_sourse_code_N_SetNull( )
      {
         gxTv_SdtBR_Death_Br_death_sourse_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Death_Br_death_sourse_code_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Death_Br_information_patientno = "";
         gxTv_SdtBR_Death_Br_death_date = DateTime.MinValue;
         gxTv_SdtBR_Death_Br_death_cause = "";
         gxTv_SdtBR_Death_Br_death_causecode = "";
         gxTv_SdtBR_Death_Br_death_causecode_code = "";
         gxTv_SdtBR_Death_Br_death_sourse = "";
         gxTv_SdtBR_Death_Br_death_sourse_code = "";
         gxTv_SdtBR_Death_Mode = "";
         gxTv_SdtBR_Death_Br_information_patientno_Z = "";
         gxTv_SdtBR_Death_Br_death_date_Z = DateTime.MinValue;
         gxTv_SdtBR_Death_Br_death_cause_Z = "";
         gxTv_SdtBR_Death_Br_death_causecode_Z = "";
         gxTv_SdtBR_Death_Br_death_causecode_code_Z = "";
         gxTv_SdtBR_Death_Br_death_sourse_Z = "";
         gxTv_SdtBR_Death_Br_death_sourse_code_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_death", "GeneXus.Programs.br_death_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Death_Initialized ;
      private short gxTv_SdtBR_Death_Br_information_patientno_N ;
      private short gxTv_SdtBR_Death_Br_death_date_N ;
      private short gxTv_SdtBR_Death_Br_death_cause_N ;
      private short gxTv_SdtBR_Death_Br_death_causecode_N ;
      private short gxTv_SdtBR_Death_Br_death_causecode_code_N ;
      private short gxTv_SdtBR_Death_Br_death_sourse_N ;
      private short gxTv_SdtBR_Death_Br_death_sourse_code_N ;
      private long gxTv_SdtBR_Death_Br_deathid ;
      private long gxTv_SdtBR_Death_Br_encounterid ;
      private long gxTv_SdtBR_Death_Br_deathid_Z ;
      private long gxTv_SdtBR_Death_Br_encounterid_Z ;
      private String gxTv_SdtBR_Death_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Death_Br_death_date ;
      private DateTime gxTv_SdtBR_Death_Br_death_date_Z ;
      private String gxTv_SdtBR_Death_Br_information_patientno ;
      private String gxTv_SdtBR_Death_Br_death_cause ;
      private String gxTv_SdtBR_Death_Br_death_causecode ;
      private String gxTv_SdtBR_Death_Br_death_causecode_code ;
      private String gxTv_SdtBR_Death_Br_death_sourse ;
      private String gxTv_SdtBR_Death_Br_death_sourse_code ;
      private String gxTv_SdtBR_Death_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Death_Br_death_cause_Z ;
      private String gxTv_SdtBR_Death_Br_death_causecode_Z ;
      private String gxTv_SdtBR_Death_Br_death_causecode_code_Z ;
      private String gxTv_SdtBR_Death_Br_death_sourse_Z ;
      private String gxTv_SdtBR_Death_Br_death_sourse_code_Z ;
   }

   [DataContract(Name = @"BR_Death", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Death_RESTInterface : GxGenericCollectionItem<SdtBR_Death>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Death_RESTInterface( ) : base()
      {
      }

      public SdtBR_Death_RESTInterface( SdtBR_Death psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_DeathID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_deathid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_deathid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_deathid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Death_Date" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_death_date
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_death_date) ;
         }

         set {
            sdt.gxTpr_Br_death_date = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Death_Cause" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_death_cause
      {
         get {
            return sdt.gxTpr_Br_death_cause ;
         }

         set {
            sdt.gxTpr_Br_death_cause = value;
         }

      }

      [DataMember( Name = "BR_Death_CauseCode" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_death_causecode
      {
         get {
            return sdt.gxTpr_Br_death_causecode ;
         }

         set {
            sdt.gxTpr_Br_death_causecode = value;
         }

      }

      [DataMember( Name = "BR_Death_CauseCode_Code" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_death_causecode_code
      {
         get {
            return sdt.gxTpr_Br_death_causecode_code ;
         }

         set {
            sdt.gxTpr_Br_death_causecode_code = value;
         }

      }

      [DataMember( Name = "BR_Death_Sourse" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_death_sourse
      {
         get {
            return sdt.gxTpr_Br_death_sourse ;
         }

         set {
            sdt.gxTpr_Br_death_sourse = value;
         }

      }

      [DataMember( Name = "BR_Death_Sourse_Code" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_death_sourse_code
      {
         get {
            return sdt.gxTpr_Br_death_sourse_code ;
         }

         set {
            sdt.gxTpr_Br_death_sourse_code = value;
         }

      }

      public SdtBR_Death sdt
      {
         get {
            return (SdtBR_Death)Sdt ;
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
            sdt = new SdtBR_Death() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 9 )]
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
