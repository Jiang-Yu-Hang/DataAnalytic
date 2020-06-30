/*
               File: type_SdtBR_Procedure
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:36.69
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
   [XmlRoot(ElementName = "BR_Procedure" )]
   [XmlType(TypeName =  "BR_Procedure" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Procedure : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure( )
      {
      }

      public SdtBR_Procedure( IGxContext context )
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

      public void Load( long AV139BR_ProcedureID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV139BR_ProcedureID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_ProcedureID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Procedure");
         metadata.Set("BT", "BR_Procedure");
         metadata.Set("PK", "[ \"BR_ProcedureID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_ProcedureID\" ]");
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
         state.Add("gxTpr_Br_procedureid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_procedure_pxid_Z");
         state.Add("gxTpr_Br_procedure_pxsurgery_Z");
         state.Add("gxTpr_Br_procedure_pxsurgery_code_Z");
         state.Add("gxTpr_Br_procedure_date_Z_Nullable");
         state.Add("gxTpr_Br_procedure_pxradiotherapy_Z");
         state.Add("gxTpr_Br_procedure_pxradiotherapy_code_Z");
         state.Add("gxTpr_Br_procedure_radiodate_Z_Nullable");
         state.Add("gxTpr_Br_procedure_radiotime_Z_double");
         state.Add("gxTpr_Br_encounterid_N");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_procedure_pxid_N");
         state.Add("gxTpr_Br_procedure_pxsurgery_N");
         state.Add("gxTpr_Br_procedure_pxsurgery_code_N");
         state.Add("gxTpr_Br_procedure_date_N");
         state.Add("gxTpr_Br_procedure_pxradiotherapy_N");
         state.Add("gxTpr_Br_procedure_pxradiotherapy_code_N");
         state.Add("gxTpr_Br_procedure_radiodate_N");
         state.Add("gxTpr_Br_procedure_radiotime_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Procedure sdt ;
         sdt = (SdtBR_Procedure)(source);
         gxTv_SdtBR_Procedure_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Br_procedureid ;
         gxTv_SdtBR_Procedure_Br_encounterid = sdt.gxTv_SdtBR_Procedure_Br_encounterid ;
         gxTv_SdtBR_Procedure_Br_information_patientno = sdt.gxTv_SdtBR_Procedure_Br_information_patientno ;
         gxTv_SdtBR_Procedure_Br_procedure_pxid = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxid ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code ;
         gxTv_SdtBR_Procedure_Br_procedure_date = sdt.gxTv_SdtBR_Procedure_Br_procedure_date ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code ;
         gxTv_SdtBR_Procedure_Br_procedure_radiodate = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiodate ;
         gxTv_SdtBR_Procedure_Br_procedure_radiotime = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiotime ;
         gxTv_SdtBR_Procedure_Mode = sdt.gxTv_SdtBR_Procedure_Mode ;
         gxTv_SdtBR_Procedure_Initialized = sdt.gxTv_SdtBR_Procedure_Initialized ;
         gxTv_SdtBR_Procedure_Br_procedureid_Z = sdt.gxTv_SdtBR_Procedure_Br_procedureid_Z ;
         gxTv_SdtBR_Procedure_Br_encounterid_Z = sdt.gxTv_SdtBR_Procedure_Br_encounterid_Z ;
         gxTv_SdtBR_Procedure_Br_information_patientno_Z = sdt.gxTv_SdtBR_Procedure_Br_information_patientno_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_pxid_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxid_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_date_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_date_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z ;
         gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z ;
         gxTv_SdtBR_Procedure_Br_encounterid_N = sdt.gxTv_SdtBR_Procedure_Br_encounterid_N ;
         gxTv_SdtBR_Procedure_Br_information_patientno_N = sdt.gxTv_SdtBR_Procedure_Br_information_patientno_N ;
         gxTv_SdtBR_Procedure_Br_procedure_pxid_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxid_N ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N ;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N ;
         gxTv_SdtBR_Procedure_Br_procedure_date_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_date_N ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N ;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N ;
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiodate_N ;
         gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiotime_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Br_procedureid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Procedure_Br_encounterid_N, false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Procedure_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Procedure_Br_information_patientno_N, false);
         AddObjectProperty("BR_Procedure_PXID", gxTv_SdtBR_Procedure_Br_procedure_pxid, false);
         AddObjectProperty("BR_Procedure_PXID_N", gxTv_SdtBR_Procedure_Br_procedure_pxid_N, false);
         AddObjectProperty("BR_Procedure_PXSurgery", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery, false);
         AddObjectProperty("BR_Procedure_PXSurgery_N", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N, false);
         AddObjectProperty("BR_Procedure_PXSurgery_Code", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code, false);
         AddObjectProperty("BR_Procedure_PXSurgery_Code_N", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Procedure_Br_procedure_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Procedure_Br_procedure_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Procedure_Br_procedure_date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Procedure_Date", sDateCnv, false);
         AddObjectProperty("BR_Procedure_Date_N", gxTv_SdtBR_Procedure_Br_procedure_date_N, false);
         AddObjectProperty("BR_Procedure_PXRadiotherapy", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy, false);
         AddObjectProperty("BR_Procedure_PXRadiotherapy_N", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N, false);
         AddObjectProperty("BR_Procedure_PXRadiotherapy_Code", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code, false);
         AddObjectProperty("BR_Procedure_PXRadiotherapy_Code_N", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Procedure_Br_procedure_radiodate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Procedure_Br_procedure_radiodate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Procedure_Br_procedure_radiodate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Procedure_RadioDate", sDateCnv, false);
         AddObjectProperty("BR_Procedure_RadioDate_N", gxTv_SdtBR_Procedure_Br_procedure_radiodate_N, false);
         AddObjectProperty("BR_Procedure_RadioTime", gxTv_SdtBR_Procedure_Br_procedure_radiotime, false);
         AddObjectProperty("BR_Procedure_RadioTime_N", gxTv_SdtBR_Procedure_Br_procedure_radiotime_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Procedure_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Procedure_Initialized, false);
            AddObjectProperty("BR_ProcedureID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Br_procedureid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Procedure_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Procedure_PXID_Z", gxTv_SdtBR_Procedure_Br_procedure_pxid_Z, false);
            AddObjectProperty("BR_Procedure_PXSurgery_Z", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z, false);
            AddObjectProperty("BR_Procedure_PXSurgery_Code_Z", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Procedure_Br_procedure_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Procedure_Br_procedure_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Procedure_Br_procedure_date_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Procedure_Date_Z", sDateCnv, false);
            AddObjectProperty("BR_Procedure_PXRadiotherapy_Z", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z, false);
            AddObjectProperty("BR_Procedure_PXRadiotherapy_Code_Z", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Procedure_RadioDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Procedure_RadioTime_Z", gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z, false);
            AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Procedure_Br_encounterid_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Procedure_Br_information_patientno_N, false);
            AddObjectProperty("BR_Procedure_PXID_N", gxTv_SdtBR_Procedure_Br_procedure_pxid_N, false);
            AddObjectProperty("BR_Procedure_PXSurgery_N", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N, false);
            AddObjectProperty("BR_Procedure_PXSurgery_Code_N", gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N, false);
            AddObjectProperty("BR_Procedure_Date_N", gxTv_SdtBR_Procedure_Br_procedure_date_N, false);
            AddObjectProperty("BR_Procedure_PXRadiotherapy_N", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N, false);
            AddObjectProperty("BR_Procedure_PXRadiotherapy_Code_N", gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N, false);
            AddObjectProperty("BR_Procedure_RadioDate_N", gxTv_SdtBR_Procedure_Br_procedure_radiodate_N, false);
            AddObjectProperty("BR_Procedure_RadioTime_N", gxTv_SdtBR_Procedure_Br_procedure_radiotime_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Procedure sdt )
      {
         if ( sdt.IsDirty("BR_ProcedureID") )
         {
            gxTv_SdtBR_Procedure_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Br_procedureid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Procedure_Br_encounterid = sdt.gxTv_SdtBR_Procedure_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Procedure_Br_information_patientno = sdt.gxTv_SdtBR_Procedure_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Procedure_PXID") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_pxid = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxid ;
         }
         if ( sdt.IsDirty("BR_Procedure_PXSurgery") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery ;
         }
         if ( sdt.IsDirty("BR_Procedure_PXSurgery_Code") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code ;
         }
         if ( sdt.IsDirty("BR_Procedure_Date") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_date = sdt.gxTv_SdtBR_Procedure_Br_procedure_date ;
         }
         if ( sdt.IsDirty("BR_Procedure_PXRadiotherapy") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy ;
         }
         if ( sdt.IsDirty("BR_Procedure_PXRadiotherapy_Code") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code = sdt.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code ;
         }
         if ( sdt.IsDirty("BR_Procedure_RadioDate") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_radiodate = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiodate ;
         }
         if ( sdt.IsDirty("BR_Procedure_RadioTime") )
         {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime = sdt.gxTv_SdtBR_Procedure_Br_procedure_radiotime ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_ProcedureID" )]
      [  XmlElement( ElementName = "BR_ProcedureID"   )]
      public long gxTpr_Br_procedureid
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedureid ;
         }

         set {
            if ( gxTv_SdtBR_Procedure_Br_procedureid != value )
            {
               gxTv_SdtBR_Procedure_Mode = "INS";
               this.gxTv_SdtBR_Procedure_Br_procedureid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_pxid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_date_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z_SetNull( );
            }
            gxTv_SdtBR_Procedure_Br_procedureid = value;
            SetDirty("Br_procedureid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Procedure_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_encounterid_N = 0;
            gxTv_SdtBR_Procedure_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_encounterid_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_encounterid_N = 1;
         gxTv_SdtBR_Procedure_Br_encounterid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_encounterid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Procedure_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_information_patientno_N = 0;
            gxTv_SdtBR_Procedure_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_information_patientno_N = 1;
         gxTv_SdtBR_Procedure_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXID" )]
      [  XmlElement( ElementName = "BR_Procedure_PXID"   )]
      public long gxTpr_Br_procedure_pxid
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxid ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxid_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_pxid = value;
            SetDirty("Br_procedure_pxid");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxid_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxid_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_pxid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery"   )]
      public String gxTpr_Br_procedure_pxsurgery
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery = value;
            SetDirty("Br_procedure_pxsurgery");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery_Code" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery_Code"   )]
      public String gxTpr_Br_procedure_pxsurgery_code
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code = value;
            SetDirty("Br_procedure_pxsurgery_code");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Date" )]
      [  XmlElement( ElementName = "BR_Procedure_Date"  , IsNullable=true )]
      public string gxTpr_Br_procedure_date_Nullable
      {
         get {
            if ( gxTv_SdtBR_Procedure_Br_procedure_date == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Procedure_Br_procedure_date).value ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_date_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Procedure_Br_procedure_date = DateTime.MinValue;
            else
               gxTv_SdtBR_Procedure_Br_procedure_date = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_procedure_date
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_date ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_date_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_date = value;
            SetDirty("Br_procedure_date");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_date_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_date_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_date = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_date_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy"   )]
      public String gxTpr_Br_procedure_pxradiotherapy
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy = value;
            SetDirty("Br_procedure_pxradiotherapy");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy_Code" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy_Code"   )]
      public String gxTpr_Br_procedure_pxradiotherapy_code
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code = value;
            SetDirty("Br_procedure_pxradiotherapy_code");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioDate" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioDate"  , IsNullable=true )]
      public string gxTpr_Br_procedure_radiodate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Procedure_Br_procedure_radiodate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Procedure_Br_procedure_radiodate).value ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Procedure_Br_procedure_radiodate = DateTime.MinValue;
            else
               gxTv_SdtBR_Procedure_Br_procedure_radiodate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_procedure_radiodate
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiodate ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_radiodate = value;
            SetDirty("Br_procedure_radiodate");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiodate_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_radiodate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiodate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioTime" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioTime"   )]
      public double gxTpr_Br_procedure_radiotime_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Procedure_Br_procedure_radiotime) ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_radiotime = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_procedure_radiotime
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiotime ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = 0;
            gxTv_SdtBR_Procedure_Br_procedure_radiotime = value;
            SetDirty("Br_procedure_radiotime");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiotime_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = 1;
         gxTv_SdtBR_Procedure_Br_procedure_radiotime = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiotime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Procedure_Mode ;
         }

         set {
            gxTv_SdtBR_Procedure_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Procedure_Mode_SetNull( )
      {
         gxTv_SdtBR_Procedure_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Procedure_Initialized ;
         }

         set {
            gxTv_SdtBR_Procedure_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Procedure_Initialized_SetNull( )
      {
         gxTv_SdtBR_Procedure_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_ProcedureID_Z" )]
      [  XmlElement( ElementName = "BR_ProcedureID_Z"   )]
      public long gxTpr_Br_procedureid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedureid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedureid_Z = value;
            SetDirty("Br_procedureid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedureid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedureid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedureid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXID_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_PXID_Z"   )]
      public long gxTpr_Br_procedure_pxid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxid_Z = value;
            SetDirty("Br_procedure_pxid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery_Z"   )]
      public String gxTpr_Br_procedure_pxsurgery_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z = value;
            SetDirty("Br_procedure_pxsurgery_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery_Code_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery_Code_Z"   )]
      public String gxTpr_Br_procedure_pxsurgery_code_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z = value;
            SetDirty("Br_procedure_pxsurgery_code_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Date_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_Date_Z"  , IsNullable=true )]
      public string gxTpr_Br_procedure_date_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Procedure_Br_procedure_date_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Procedure_Br_procedure_date_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Procedure_Br_procedure_date_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Procedure_Br_procedure_date_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_procedure_date_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_date_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_date_Z = value;
            SetDirty("Br_procedure_date_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_date_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_date_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_date_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy_Z"   )]
      public String gxTpr_Br_procedure_pxradiotherapy_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z = value;
            SetDirty("Br_procedure_pxradiotherapy_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy_Code_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy_Code_Z"   )]
      public String gxTpr_Br_procedure_pxradiotherapy_code_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z = value;
            SetDirty("Br_procedure_pxradiotherapy_code_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioDate_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_procedure_radiodate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_procedure_radiodate_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = value;
            SetDirty("Br_procedure_radiodate_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioTime_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioTime_Z"   )]
      public double gxTpr_Br_procedure_radiotime_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z) ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_procedure_radiotime_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z = value;
            SetDirty("Br_procedure_radiotime_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_N" )]
      [  XmlElement( ElementName = "BR_EncounterID_N"   )]
      public short gxTpr_Br_encounterid_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_encounterid_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_encounterid_N = value;
            SetDirty("Br_encounterid_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_encounterid_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_encounterid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_encounterid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXID_N" )]
      [  XmlElement( ElementName = "BR_Procedure_PXID_N"   )]
      public short gxTpr_Br_procedure_pxid_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxid_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxid_N = value;
            SetDirty("Br_procedure_pxid_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxid_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery_N" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery_N"   )]
      public short gxTpr_Br_procedure_pxsurgery_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N = value;
            SetDirty("Br_procedure_pxsurgery_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXSurgery_Code_N" )]
      [  XmlElement( ElementName = "BR_Procedure_PXSurgery_Code_N"   )]
      public short gxTpr_Br_procedure_pxsurgery_code_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N = value;
            SetDirty("Br_procedure_pxsurgery_code_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Date_N" )]
      [  XmlElement( ElementName = "BR_Procedure_Date_N"   )]
      public short gxTpr_Br_procedure_date_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_date_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_date_N = value;
            SetDirty("Br_procedure_date_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_date_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_date_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_date_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy_N" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy_N"   )]
      public short gxTpr_Br_procedure_pxradiotherapy_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N = value;
            SetDirty("Br_procedure_pxradiotherapy_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_PXRadiotherapy_Code_N" )]
      [  XmlElement( ElementName = "BR_Procedure_PXRadiotherapy_Code_N"   )]
      public short gxTpr_Br_procedure_pxradiotherapy_code_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N = value;
            SetDirty("Br_procedure_pxradiotherapy_code_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioDate_N" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioDate_N"   )]
      public short gxTpr_Br_procedure_radiodate_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiodate_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = value;
            SetDirty("Br_procedure_radiodate_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiodate_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiodate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioTime_N" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioTime_N"   )]
      public short gxTpr_Br_procedure_radiotime_N
      {
         get {
            return gxTv_SdtBR_Procedure_Br_procedure_radiotime_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = value;
            SetDirty("Br_procedure_radiotime_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Br_procedure_radiotime_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Br_procedure_radiotime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Br_procedure_radiotime_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Procedure_Br_information_patientno = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code = "";
         gxTv_SdtBR_Procedure_Br_procedure_date = DateTime.MinValue;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code = "";
         gxTv_SdtBR_Procedure_Br_procedure_radiodate = DateTime.MinValue;
         gxTv_SdtBR_Procedure_Mode = "";
         gxTv_SdtBR_Procedure_Br_information_patientno_Z = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z = "";
         gxTv_SdtBR_Procedure_Br_procedure_date_Z = DateTime.MinValue;
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z = "";
         gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z = "";
         gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z = DateTime.MinValue;
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_procedure", "GeneXus.Programs.br_procedure_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Procedure_Initialized ;
      private short gxTv_SdtBR_Procedure_Br_encounterid_N ;
      private short gxTv_SdtBR_Procedure_Br_information_patientno_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_pxid_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_date_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_radiodate_N ;
      private short gxTv_SdtBR_Procedure_Br_procedure_radiotime_N ;
      private long gxTv_SdtBR_Procedure_Br_procedureid ;
      private long gxTv_SdtBR_Procedure_Br_encounterid ;
      private long gxTv_SdtBR_Procedure_Br_procedure_pxid ;
      private long gxTv_SdtBR_Procedure_Br_procedureid_Z ;
      private long gxTv_SdtBR_Procedure_Br_encounterid_Z ;
      private long gxTv_SdtBR_Procedure_Br_procedure_pxid_Z ;
      private decimal gxTv_SdtBR_Procedure_Br_procedure_radiotime ;
      private decimal gxTv_SdtBR_Procedure_Br_procedure_radiotime_Z ;
      private String gxTv_SdtBR_Procedure_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Procedure_Br_procedure_date ;
      private DateTime gxTv_SdtBR_Procedure_Br_procedure_radiodate ;
      private DateTime gxTv_SdtBR_Procedure_Br_procedure_date_Z ;
      private DateTime gxTv_SdtBR_Procedure_Br_procedure_radiodate_Z ;
      private String gxTv_SdtBR_Procedure_Br_information_patientno ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxsurgery ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code ;
      private String gxTv_SdtBR_Procedure_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_Z ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxsurgery_code_Z ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_Z ;
      private String gxTv_SdtBR_Procedure_Br_procedure_pxradiotherapy_code_Z ;
   }

   [DataContract(Name = @"BR_Procedure", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Procedure_RESTInterface : GxGenericCollectionItem<SdtBR_Procedure>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure_RESTInterface( ) : base()
      {
      }

      public SdtBR_Procedure_RESTInterface( SdtBR_Procedure psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_ProcedureID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_procedureid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_procedureid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_procedureid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Procedure_PXID" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_pxid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_procedure_pxid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_procedure_pxid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Procedure_PXSurgery" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_pxsurgery
      {
         get {
            return sdt.gxTpr_Br_procedure_pxsurgery ;
         }

         set {
            sdt.gxTpr_Br_procedure_pxsurgery = value;
         }

      }

      [DataMember( Name = "BR_Procedure_PXSurgery_Code" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_pxsurgery_code
      {
         get {
            return sdt.gxTpr_Br_procedure_pxsurgery_code ;
         }

         set {
            sdt.gxTpr_Br_procedure_pxsurgery_code = value;
         }

      }

      [DataMember( Name = "BR_Procedure_Date" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_date
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_procedure_date) ;
         }

         set {
            sdt.gxTpr_Br_procedure_date = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Procedure_PXRadiotherapy" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_pxradiotherapy
      {
         get {
            return sdt.gxTpr_Br_procedure_pxradiotherapy ;
         }

         set {
            sdt.gxTpr_Br_procedure_pxradiotherapy = value;
         }

      }

      [DataMember( Name = "BR_Procedure_PXRadiotherapy_Code" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_pxradiotherapy_code
      {
         get {
            return sdt.gxTpr_Br_procedure_pxradiotherapy_code ;
         }

         set {
            sdt.gxTpr_Br_procedure_pxradiotherapy_code = value;
         }

      }

      [DataMember( Name = "BR_Procedure_RadioDate" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_radiodate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_procedure_radiodate) ;
         }

         set {
            sdt.gxTpr_Br_procedure_radiodate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Procedure_RadioTime" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_radiotime
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_procedure_radiotime, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_procedure_radiotime = NumberUtil.Val( value, ".");
         }

      }

      public SdtBR_Procedure sdt
      {
         get {
            return (SdtBR_Procedure)Sdt ;
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
            sdt = new SdtBR_Procedure() ;
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
