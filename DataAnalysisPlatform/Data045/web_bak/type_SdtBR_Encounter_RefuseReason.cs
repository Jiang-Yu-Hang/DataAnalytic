/*
               File: type_SdtBR_Encounter_RefuseReason
        Description: 就诊信息驳回原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:52.7
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
   [XmlRoot(ElementName = "BR_Encounter_RefuseReason" )]
   [XmlType(TypeName =  "BR_Encounter_RefuseReason" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Encounter_RefuseReason : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Encounter_RefuseReason( )
      {
      }

      public SdtBR_Encounter_RefuseReason( IGxContext context )
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

      public void Load( long AV348BR_Encounter_RefuseReasonID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV348BR_Encounter_RefuseReasonID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Encounter_RefuseReasonID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Encounter_RefuseReason");
         metadata.Set("BT", "BR_Encounter_RefuseReason");
         metadata.Set("PK", "[ \"BR_Encounter_RefuseReasonID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Encounter_RefuseReasonID\" ]");
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
         state.Add("gxTpr_Br_encounter_refusereasonid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_encounter_refusereason_reason_Z");
         state.Add("gxTpr_Br_encounter_refusereason_noapprovedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_refusereason_status_Z");
         state.Add("gxTpr_Br_encounter_refusereason_approver_Z");
         state.Add("gxTpr_Br_encounterreason_isapprove_Z");
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Br_encounterreason_vstatus_Z");
         state.Add("gxTpr_Br_encounter_refusereason_freason_Z");
         state.Add("gxTpr_Br_encounter_refusereason_fapprovedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_refusereason_reason_N");
         state.Add("gxTpr_Br_encounter_refusereason_noapprovedate_N");
         state.Add("gxTpr_Br_encounter_refusereason_status_N");
         state.Add("gxTpr_Br_encounter_refusereason_approver_N");
         state.Add("gxTpr_Br_encounterreason_isapprove_N");
         state.Add("gxTpr_Br_information_id_N");
         state.Add("gxTpr_Br_encounterreason_vstatus_N");
         state.Add("gxTpr_Br_encounter_refusereason_freason_N");
         state.Add("gxTpr_Br_encounter_refusereason_fapprovedate_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Encounter_RefuseReason sdt ;
         sdt = (SdtBR_Encounter_RefuseReason)(source);
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_information_id ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate ;
         gxTv_SdtBR_Encounter_RefuseReason_Mode = sdt.gxTv_SdtBR_Encounter_RefuseReason_Mode ;
         gxTv_SdtBR_Encounter_RefuseReason_Initialized = sdt.gxTv_SdtBR_Encounter_RefuseReason_Initialized ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N ;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Encounter_RefuseReason_Reason", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason, false);
         AddObjectProperty("BR_Encounter_RefuseReason_Reason_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate;
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
         AddObjectProperty("BR_Encounter_RefuseReason_NoApproveDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_RefuseReason_NoApproveDate_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N, false);
         AddObjectProperty("BR_Encounter_RefuseReason_Status", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status, false);
         AddObjectProperty("BR_Encounter_RefuseReason_Status_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N, false);
         AddObjectProperty("BR_Encounter_RefuseReason_Approver", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver, false);
         AddObjectProperty("BR_Encounter_RefuseReason_Approver_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N, false);
         AddObjectProperty("BR_EncounterReason_IsApprove", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove, false);
         AddObjectProperty("BR_EncounterReason_IsApprove_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N, false);
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_information_id), 18, 0)), false);
         AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N, false);
         AddObjectProperty("BR_EncounterReason_vStatus", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus, false);
         AddObjectProperty("BR_EncounterReason_vStatus_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N, false);
         AddObjectProperty("BR_Encounter_RefuseReason_FReason", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason, false);
         AddObjectProperty("BR_Encounter_RefuseReason_FReason_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate;
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
         AddObjectProperty("BR_Encounter_RefuseReason_FApproveDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_RefuseReason_FApproveDate_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Encounter_RefuseReason_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Encounter_RefuseReason_Initialized, false);
            AddObjectProperty("BR_Encounter_RefuseReasonID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Encounter_RefuseReason_Reason_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z;
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
            AddObjectProperty("BR_Encounter_RefuseReason_NoApproveDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_RefuseReason_Status_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z, false);
            AddObjectProperty("BR_Encounter_RefuseReason_Approver_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z, false);
            AddObjectProperty("BR_EncounterReason_IsApprove_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z, false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterReason_vStatus_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z, false);
            AddObjectProperty("BR_Encounter_RefuseReason_FReason_Z", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z;
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
            AddObjectProperty("BR_Encounter_RefuseReason_FApproveDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_RefuseReason_Reason_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N, false);
            AddObjectProperty("BR_Encounter_RefuseReason_NoApproveDate_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N, false);
            AddObjectProperty("BR_Encounter_RefuseReason_Status_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N, false);
            AddObjectProperty("BR_Encounter_RefuseReason_Approver_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N, false);
            AddObjectProperty("BR_EncounterReason_IsApprove_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N, false);
            AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N, false);
            AddObjectProperty("BR_EncounterReason_vStatus_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N, false);
            AddObjectProperty("BR_Encounter_RefuseReason_FReason_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N, false);
            AddObjectProperty("BR_Encounter_RefuseReason_FApproveDate_N", gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Encounter_RefuseReason sdt )
      {
         if ( sdt.IsDirty("BR_Encounter_RefuseReasonID") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_Reason") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_NoApproveDate") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_Status") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_Approver") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_IsApprove") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove ;
         }
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_information_id = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_information_id ;
         }
         if ( sdt.IsDirty("BR_EncounterReason_vStatus") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_FReason") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason ;
         }
         if ( sdt.IsDirty("BR_Encounter_RefuseReason_FApproveDate") )
         {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = sdt.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReasonID" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReasonID"   )]
      public long gxTpr_Br_encounter_refusereasonid
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid ;
         }

         set {
            if ( gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid != value )
            {
               gxTv_SdtBR_Encounter_RefuseReason_Mode = "INS";
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z_SetNull( );
            }
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid = value;
            SetDirty("Br_encounter_refusereasonid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Reason" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Reason"   )]
      public String gxTpr_Br_encounter_refusereason_reason
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason = value;
            SetDirty("Br_encounter_refusereason_reason");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_refusereason_noapprovedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_refusereason_noapprovedate
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = value;
            SetDirty("Br_encounter_refusereason_noapprovedate");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Status" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Status"   )]
      public short gxTpr_Br_encounter_refusereason_status
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status = value;
            SetDirty("Br_encounter_refusereason_status");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Approver" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Approver"   )]
      public String gxTpr_Br_encounter_refusereason_approver
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver = value;
            SetDirty("Br_encounter_refusereason_approver");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsApprove" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsApprove"   )]
      public bool gxTpr_Br_encounterreason_isapprove
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove = value;
            SetDirty("Br_encounterreason_isapprove");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_information_id ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_vStatus" )]
      [  XmlElement( ElementName = "BR_EncounterReason_vStatus"   )]
      public short gxTpr_Br_encounterreason_vstatus
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus = value;
            SetDirty("Br_encounterreason_vstatus");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FReason" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FReason"   )]
      public String gxTpr_Br_encounter_refusereason_freason
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason = value;
            SetDirty("Br_encounter_refusereason_freason");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_refusereason_fapprovedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_refusereason_fapprovedate
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = 0;
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = value;
            SetDirty("Br_encounter_refusereason_fapprovedate");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = 1;
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Mode ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Mode_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Initialized ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Initialized_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReasonID_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReasonID_Z"   )]
      public long gxTpr_Br_encounter_refusereasonid_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z = value;
            SetDirty("Br_encounter_refusereasonid_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Reason_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Reason_Z"   )]
      public String gxTpr_Br_encounter_refusereason_reason_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z = value;
            SetDirty("Br_encounter_refusereason_reason_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_refusereason_noapprovedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_refusereason_noapprovedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = value;
            SetDirty("Br_encounter_refusereason_noapprovedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Status_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Status_Z"   )]
      public short gxTpr_Br_encounter_refusereason_status_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z = value;
            SetDirty("Br_encounter_refusereason_status_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Approver_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Approver_Z"   )]
      public String gxTpr_Br_encounter_refusereason_approver_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z = value;
            SetDirty("Br_encounter_refusereason_approver_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsApprove_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsApprove_Z"   )]
      public bool gxTpr_Br_encounterreason_isapprove_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z = value;
            SetDirty("Br_encounterreason_isapprove_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_vStatus_Z" )]
      [  XmlElement( ElementName = "BR_EncounterReason_vStatus_Z"   )]
      public short gxTpr_Br_encounterreason_vstatus_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z = value;
            SetDirty("Br_encounterreason_vstatus_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FReason_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FReason_Z"   )]
      public String gxTpr_Br_encounter_refusereason_freason_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z = value;
            SetDirty("Br_encounter_refusereason_freason_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_refusereason_fapprovedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_refusereason_fapprovedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = value;
            SetDirty("Br_encounter_refusereason_fapprovedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Reason_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Reason_N"   )]
      public short gxTpr_Br_encounter_refusereason_reason_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N = value;
            SetDirty("Br_encounter_refusereason_reason_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_NoApproveDate_N"   )]
      public short gxTpr_Br_encounter_refusereason_noapprovedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = value;
            SetDirty("Br_encounter_refusereason_noapprovedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Status_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Status_N"   )]
      public short gxTpr_Br_encounter_refusereason_status_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N = value;
            SetDirty("Br_encounter_refusereason_status_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_Approver_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_Approver_N"   )]
      public short gxTpr_Br_encounter_refusereason_approver_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N = value;
            SetDirty("Br_encounter_refusereason_approver_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_IsApprove_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_IsApprove_N"   )]
      public short gxTpr_Br_encounterreason_isapprove_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N = value;
            SetDirty("Br_encounterreason_isapprove_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_N" )]
      [  XmlElement( ElementName = "BR_Information_ID_N"   )]
      public short gxTpr_Br_information_id_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N = value;
            SetDirty("Br_information_id_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterReason_vStatus_N" )]
      [  XmlElement( ElementName = "BR_EncounterReason_vStatus_N"   )]
      public short gxTpr_Br_encounterreason_vstatus_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N = value;
            SetDirty("Br_encounterreason_vstatus_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FReason_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FReason_N"   )]
      public short gxTpr_Br_encounter_refusereason_freason_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N = value;
            SetDirty("Br_encounter_refusereason_freason_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RefuseReason_FApproveDate_N"   )]
      public short gxTpr_Br_encounter_refusereason_fapprovedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = value;
            SetDirty("Br_encounter_refusereason_fapprovedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_RefuseReason_Mode = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z = "";
         gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_encounter_refusereason", "GeneXus.Programs.br_encounter_refusereason_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Initialized ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_Z ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_Z ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_status_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_vstatus_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_N ;
      private short gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_N ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_information_id ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereasonid_Z ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_encounterid_Z ;
      private long gxTv_SdtBR_Encounter_RefuseReason_Br_information_id_Z ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate ;
      private DateTime gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate ;
      private DateTime gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_noapprovedate_Z ;
      private DateTime gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_fapprovedate_Z ;
      private DateTime datetime_STZ ;
      private bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove ;
      private bool gxTv_SdtBR_Encounter_RefuseReason_Br_encounterreason_isapprove_Z ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_reason_Z ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_approver_Z ;
      private String gxTv_SdtBR_Encounter_RefuseReason_Br_encounter_refusereason_freason_Z ;
   }

   [DataContract(Name = @"BR_Encounter_RefuseReason", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Encounter_RefuseReason_RESTInterface : GxGenericCollectionItem<SdtBR_Encounter_RefuseReason>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Encounter_RefuseReason_RESTInterface( ) : base()
      {
      }

      public SdtBR_Encounter_RefuseReason_RESTInterface( SdtBR_Encounter_RefuseReason psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Encounter_RefuseReasonID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereasonid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounter_refusereasonid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereasonid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Encounter_RefuseReason_Reason" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereason_reason
      {
         get {
            return sdt.gxTpr_Br_encounter_refusereason_reason ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_reason = value;
         }

      }

      [DataMember( Name = "BR_Encounter_RefuseReason_NoApproveDate" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereason_noapprovedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_refusereason_noapprovedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_noapprovedate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_RefuseReason_Status" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_encounter_refusereason_status
      {
         get {
            return sdt.gxTpr_Br_encounter_refusereason_status ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_status = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_Encounter_RefuseReason_Approver" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereason_approver
      {
         get {
            return sdt.gxTpr_Br_encounter_refusereason_approver ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_approver = value;
         }

      }

      [DataMember( Name = "BR_EncounterReason_IsApprove" , Order = 6 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounterreason_isapprove
      {
         get {
            return sdt.gxTpr_Br_encounterreason_isapprove ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_isapprove = value;
         }

      }

      [DataMember( Name = "BR_Information_ID" , Order = 7 )]
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

      [DataMember( Name = "BR_EncounterReason_vStatus" , Order = 8 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_encounterreason_vstatus
      {
         get {
            return sdt.gxTpr_Br_encounterreason_vstatus ;
         }

         set {
            sdt.gxTpr_Br_encounterreason_vstatus = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_Encounter_RefuseReason_FReason" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereason_freason
      {
         get {
            return sdt.gxTpr_Br_encounter_refusereason_freason ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_freason = value;
         }

      }

      [DataMember( Name = "BR_Encounter_RefuseReason_FApproveDate" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_refusereason_fapprovedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_refusereason_fapprovedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_refusereason_fapprovedate = DateTimeUtil.CToT2( value);
         }

      }

      public SdtBR_Encounter_RefuseReason sdt
      {
         get {
            return (SdtBR_Encounter_RefuseReason)Sdt ;
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
            sdt = new SdtBR_Encounter_RefuseReason() ;
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
