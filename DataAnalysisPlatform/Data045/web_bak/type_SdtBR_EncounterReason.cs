/*
               File: type_SdtBR_EncounterReason
        Description: 初审不通过原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:45.26
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
   [XmlRoot(ElementName = "BR_EncounterReason" )]
   [XmlType(TypeName =  "BR_EncounterReason" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_EncounterReason : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_EncounterReason( )
      {
      }

      public SdtBR_EncounterReason( IGxContext context )
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

      public void Load( long AV347BR_Encounter_ID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV347BR_Encounter_ID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Encounter_ID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_EncounterReason");
         metadata.Set("BT", "BR_EncounterReason");
         metadata.Set("PK", "[ \"BR_Encounter_ID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Encounter_ID\" ]");
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
         state.Add("gxTpr_Br_encounter_id_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_encounterreason_reason_Z");
         state.Add("gxTpr_Br_encounterreason_israndnoapprovedate_Z_Nullable");
         state.Add("gxTpr_Br_encounterreason_israndapprove_Z");
         state.Add("gxTpr_Br_encounterreason_status_Z");
         state.Add("gxTpr_Br_encounterreason_israndapprover_Z");
         state.Add("gxTpr_Br_encounterreason_reason_N");
         state.Add("gxTpr_Br_encounterreason_israndnoapprovedate_N");
         state.Add("gxTpr_Br_encounterreason_israndapprove_N");
         state.Add("gxTpr_Br_encounterreason_status_N");
         state.Add("gxTpr_Br_encounterreason_israndapprover_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_EncounterReason sdt ;
         sdt = (SdtBR_EncounterReason)(source);
         gxTv_SdtBR_EncounterReason_Br_encounter_id = sdt.gxTv_SdtBR_EncounterReason_Br_encounter_id ;
         gxTv_SdtBR_EncounterReason_Br_encounterid = sdt.gxTv_SdtBR_EncounterReason_Br_encounterid ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_reason ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_status ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover ;
         gxTv_SdtBR_EncounterReason_Mode = sdt.gxTv_SdtBR_EncounterReason_Mode ;
         gxTv_SdtBR_EncounterReason_Initialized = sdt.gxTv_SdtBR_EncounterReason_Initialized ;
         gxTv_SdtBR_EncounterReason_Br_encounter_id_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounter_id_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterid_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterid_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N ;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Encounter_ID", gxTv_SdtBR_EncounterReason_Br_encounter_id, false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_EncounterReason_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_EncounterReason_Reason", gxTv_SdtBR_EncounterReason_Br_encounterreason_reason, false);
         AddObjectProperty("BR_EncounterReason_Reason_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N, false);
         datetime_STZ = gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate;
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
         AddObjectProperty("BR_EncounterReason_IsRandNoApproveDate", sDateCnv, false);
         AddObjectProperty("BR_EncounterReason_IsRandNoApproveDate_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N, false);
         AddObjectProperty("BR_EncounterReason_IsRandApprove", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove, false);
         AddObjectProperty("BR_EncounterReason_IsRandApprove_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N, false);
         AddObjectProperty("BR_EncounterReason_Status", gxTv_SdtBR_EncounterReason_Br_encounterreason_status, false);
         AddObjectProperty("BR_EncounterReason_Status_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N, false);
         AddObjectProperty("BR_EncounterReason_IsRandApprover", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover, false);
         AddObjectProperty("BR_EncounterReason_IsRandApprover_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_EncounterReason_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_EncounterReason_Initialized, false);
            AddObjectProperty("BR_Encounter_ID_Z", gxTv_SdtBR_EncounterReason_Br_encounter_id_Z, false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_EncounterReason_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterReason_Reason_Z", gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z, false);
            datetime_STZ = gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z;
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
            AddObjectProperty("BR_EncounterReason_IsRandNoApproveDate_Z", sDateCnv, false);
            AddObjectProperty("BR_EncounterReason_IsRandApprove_Z", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z, false);
            AddObjectProperty("BR_EncounterReason_Status_Z", gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z, false);
            AddObjectProperty("BR_EncounterReason_IsRandApprover_Z", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z, false);
            AddObjectProperty("BR_EncounterReason_Reason_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N, false);
            AddObjectProperty("BR_EncounterReason_IsRandNoApproveDate_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N, false);
            AddObjectProperty("BR_EncounterReason_IsRandApprove_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N, false);
            AddObjectProperty("BR_EncounterReason_Status_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N, false);
            AddObjectProperty("BR_EncounterReason_IsRandApprover_N", gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_EncounterReason sdt )
      {
         if ( sdt.IsDirty("BR_Encounter_ID") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounter_id = sdt.gxTv_SdtBR_EncounterReason_Br_encounter_id ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterid = sdt.gxTv_SdtBR_EncounterReason_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_Reason") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_reason = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_reason ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_IsRandNoApproveDate") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_IsRandApprove") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_Status") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_status = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_status ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_IsRandApprover") )
         {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover = sdt.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ID" )]
      [  XmlElement( ElementName = "BR_Encounter_ID"   )]
      public long gxTpr_Br_encounter_id
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounter_id ;
         }

         set {
            if ( gxTv_SdtBR_EncounterReason_Br_encounter_id != value )
            {
               gxTv_SdtBR_EncounterReason_Mode = "INS";
               this.gxTv_SdtBR_EncounterReason_Br_encounter_id_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z_SetNull( );
               this.gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z_SetNull( );
            }
            gxTv_SdtBR_EncounterReason_Br_encounter_id = value;
            SetDirty("Br_encounter_id");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterReason_Reason" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Reason"   )]
      public String gxTpr_Br_encounterreason_reason
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_reason ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N = 0;
            gxTv_SdtBR_EncounterReason_Br_encounterreason_reason = value;
            SetDirty("Br_encounterreason_reason");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N = 1;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason = "";
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounterreason_israndnoapprovedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate).value ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = DateTime.MinValue;
            else
               gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounterreason_israndnoapprovedate
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = 0;
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = value;
            SetDirty("Br_encounterreason_israndnoapprovedate");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = 1;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprove" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprove"   )]
      public bool gxTpr_Br_encounterreason_israndapprove
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N = 0;
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove = value;
            SetDirty("Br_encounterreason_israndapprove");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N = 1;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove = false;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_Status" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Status"   )]
      public short gxTpr_Br_encounterreason_status
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_status ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N = 0;
            gxTv_SdtBR_EncounterReason_Br_encounterreason_status = value;
            SetDirty("Br_encounterreason_status");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_status_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N = 1;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_status_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprover" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprover"   )]
      public String gxTpr_Br_encounterreason_israndapprover
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N = 0;
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover = value;
            SetDirty("Br_encounterreason_israndapprover");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N = 1;
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover = "";
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_EncounterReason_Mode ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Mode_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_EncounterReason_Initialized ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Initialized_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ID_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_ID_Z"   )]
      public long gxTpr_Br_encounter_id_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounter_id_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounter_id_Z = value;
            SetDirty("Br_encounter_id_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounter_id_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounter_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounter_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_Reason_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Reason_Z"   )]
      public String gxTpr_Br_encounterreason_reason_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z = value;
            SetDirty("Br_encounterreason_reason_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounterreason_israndnoapprovedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounterreason_israndnoapprovedate_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = value;
            SetDirty("Br_encounterreason_israndnoapprovedate_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprove_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprove_Z"   )]
      public bool gxTpr_Br_encounterreason_israndapprove_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z = value;
            SetDirty("Br_encounterreason_israndapprove_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_Status_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Status_Z"   )]
      public short gxTpr_Br_encounterreason_status_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z = value;
            SetDirty("Br_encounterreason_status_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprover_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprover_Z"   )]
      public String gxTpr_Br_encounterreason_israndapprover_Z
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z = value;
            SetDirty("Br_encounterreason_israndapprover_Z");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_Reason_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Reason_N"   )]
      public short gxTpr_Br_encounterreason_reason_N
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N = value;
            SetDirty("Br_encounterreason_reason_N");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandNoApproveDate_N"   )]
      public short gxTpr_Br_encounterreason_israndnoapprovedate_N
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = value;
            SetDirty("Br_encounterreason_israndnoapprovedate_N");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprove_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprove_N"   )]
      public short gxTpr_Br_encounterreason_israndapprove_N
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N = value;
            SetDirty("Br_encounterreason_israndapprove_N");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_Status_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_Status_N"   )]
      public short gxTpr_Br_encounterreason_status_N
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N = value;
            SetDirty("Br_encounterreason_status_N");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsRandApprover_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsRandApprover_N"   )]
      public short gxTpr_Br_encounterreason_israndapprover_N
      {
         get {
            return gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N ;
         }

         set {
            gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N = value;
            SetDirty("Br_encounterreason_israndapprover_N");
         }

      }

      public void gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N_SetNull( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason = "";
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover = "";
         gxTv_SdtBR_EncounterReason_Mode = "";
         gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z = "";
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_encounterreason", "GeneXus.Programs.br_encounterreason_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_status ;
      private short gxTv_SdtBR_EncounterReason_Initialized ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_status_Z ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_N ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_N ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_N ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_status_N ;
      private short gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_N ;
      private long gxTv_SdtBR_EncounterReason_Br_encounter_id ;
      private long gxTv_SdtBR_EncounterReason_Br_encounterid ;
      private long gxTv_SdtBR_EncounterReason_Br_encounter_id_Z ;
      private long gxTv_SdtBR_EncounterReason_Br_encounterid_Z ;
      private String gxTv_SdtBR_EncounterReason_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate ;
      private DateTime gxTv_SdtBR_EncounterReason_Br_encounterreason_israndnoapprovedate_Z ;
      private DateTime datetime_STZ ;
      private bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove ;
      private bool gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprove_Z ;
      private String gxTv_SdtBR_EncounterReason_Br_encounterreason_reason ;
      private String gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover ;
      private String gxTv_SdtBR_EncounterReason_Br_encounterreason_reason_Z ;
      private String gxTv_SdtBR_EncounterReason_Br_encounterreason_israndapprover_Z ;
   }

   [DataContract(Name = @"BR_EncounterReason", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_EncounterReason_RESTInterface : GxGenericCollectionItem<SdtBR_EncounterReason>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_EncounterReason_RESTInterface( ) : base()
      {
      }

      public SdtBR_EncounterReason_RESTInterface( SdtBR_EncounterReason psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Encounter_ID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounter_id), 15, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounter_id = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_EncounterReason_Reason" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterreason_reason
      {
         get {
            return sdt.gxTpr_Br_encounterreason_reason ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_reason = value;
         }

      }

      [DataMember( Name = "BR_EncounterReason_IsRandNoApproveDate" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterreason_israndnoapprovedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounterreason_israndnoapprovedate) ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_israndnoapprovedate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_EncounterReason_IsRandApprove" , Order = 4 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounterreason_israndapprove
      {
         get {
            return sdt.gxTpr_Br_encounterreason_israndapprove ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_israndapprove = value;
         }

      }

      [DataMember( Name = "BR_EncounterReason_Status" , Order = 5 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_encounterreason_status
      {
         get {
            return sdt.gxTpr_Br_encounterreason_status ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_status = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_EncounterReason_IsRandApprover" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterreason_israndapprover
      {
         get {
            return sdt.gxTpr_Br_encounterreason_israndapprover ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_israndapprover = value;
         }

      }

      public SdtBR_EncounterReason sdt
      {
         get {
            return (SdtBR_EncounterReason)Sdt ;
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
            sdt = new SdtBR_EncounterReason() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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
