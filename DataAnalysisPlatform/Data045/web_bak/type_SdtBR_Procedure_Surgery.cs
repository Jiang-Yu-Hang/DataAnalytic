/*
               File: type_SdtBR_Procedure_Surgery
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:19.22
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
   [XmlRoot(ElementName = "BR_Procedure_Surgery" )]
   [XmlType(TypeName =  "BR_Procedure_Surgery" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Procedure_Surgery : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure_Surgery( )
      {
      }

      public SdtBR_Procedure_Surgery( IGxContext context )
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

      public void Load( long AV320BR_Procedure_SurgeryID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV320BR_Procedure_SurgeryID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Procedure_SurgeryID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Procedure_Surgery");
         metadata.Set("BT", "BR_Procedure_Surgery");
         metadata.Set("PK", "[ \"BR_Procedure_SurgeryID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Procedure_SurgeryID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_ProcedureID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_procedure_surgeryid_Z");
         state.Add("gxTpr_Br_procedureid_Z");
         state.Add("gxTpr_Br_procedure_surgery_name_Z");
         state.Add("gxTpr_Br_procedure_surgery_loc_Z");
         state.Add("gxTpr_Br_procedure_surgery_name_N");
         state.Add("gxTpr_Br_procedure_surgery_loc_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Procedure_Surgery sdt ;
         sdt = (SdtBR_Procedure_Surgery)(source);
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedureid ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc ;
         gxTv_SdtBR_Procedure_Surgery_Mode = sdt.gxTv_SdtBR_Procedure_Surgery_Mode ;
         gxTv_SdtBR_Procedure_Surgery_Initialized = sdt.gxTv_SdtBR_Procedure_Surgery_Initialized ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N ;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid), 18, 0)), false);
         AddObjectProperty("BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Surgery_Br_procedureid), 18, 0)), false);
         AddObjectProperty("BR_Procedure_Surgery_Name", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name, false);
         AddObjectProperty("BR_Procedure_Surgery_Name_N", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N, false);
         AddObjectProperty("BR_Procedure_Surgery_Loc", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc, false);
         AddObjectProperty("BR_Procedure_Surgery_Loc_N", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Procedure_Surgery_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Procedure_Surgery_Initialized, false);
            AddObjectProperty("BR_Procedure_SurgeryID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z), 18, 0)), false);
            AddObjectProperty("BR_ProcedureID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z), 18, 0)), false);
            AddObjectProperty("BR_Procedure_Surgery_Name_Z", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z, false);
            AddObjectProperty("BR_Procedure_Surgery_Loc_Z", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z, false);
            AddObjectProperty("BR_Procedure_Surgery_Name_N", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N, false);
            AddObjectProperty("BR_Procedure_Surgery_Loc_N", gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Procedure_Surgery sdt )
      {
         if ( sdt.IsDirty("BR_Procedure_SurgeryID") )
         {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid ;
         }
         if ( sdt.IsDirty("BR_ProcedureID") )
         {
            gxTv_SdtBR_Procedure_Surgery_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedureid ;
         }
         if ( sdt.IsDirty("BR_Procedure_Surgery_Name") )
         {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name ;
         }
         if ( sdt.IsDirty("BR_Procedure_Surgery_Loc") )
         {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc = sdt.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Procedure_SurgeryID" )]
      [  XmlElement( ElementName = "BR_Procedure_SurgeryID"   )]
      public long gxTpr_Br_procedure_surgeryid
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid ;
         }

         set {
            if ( gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid != value )
            {
               gxTv_SdtBR_Procedure_Surgery_Mode = "INS";
               this.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z_SetNull( );
            }
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid = value;
            SetDirty("Br_procedure_surgeryid");
         }

      }

      [  SoapElement( ElementName = "BR_ProcedureID" )]
      [  XmlElement( ElementName = "BR_ProcedureID"   )]
      public long gxTpr_Br_procedureid
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedureid ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedureid = value;
            SetDirty("Br_procedureid");
         }

      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Name" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Name"   )]
      public String gxTpr_Br_procedure_surgery_name
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N = 0;
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name = value;
            SetDirty("Br_procedure_surgery_name");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N = 1;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Loc" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Loc"   )]
      public String gxTpr_Br_procedure_surgery_loc
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N = 0;
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc = value;
            SetDirty("Br_procedure_surgery_loc");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N = 1;
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Mode ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Mode_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Initialized ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Initialized_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_SurgeryID_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_SurgeryID_Z"   )]
      public long gxTpr_Br_procedure_surgeryid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z = value;
            SetDirty("Br_procedure_surgeryid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_ProcedureID_Z" )]
      [  XmlElement( ElementName = "BR_ProcedureID_Z"   )]
      public long gxTpr_Br_procedureid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z = value;
            SetDirty("Br_procedureid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Name_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Name_Z"   )]
      public String gxTpr_Br_procedure_surgery_name_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z = value;
            SetDirty("Br_procedure_surgery_name_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Loc_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Loc_Z"   )]
      public String gxTpr_Br_procedure_surgery_loc_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z = value;
            SetDirty("Br_procedure_surgery_loc_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Name_N" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Name_N"   )]
      public short gxTpr_Br_procedure_surgery_name_N
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N = value;
            SetDirty("Br_procedure_surgery_name_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Surgery_Loc_N" )]
      [  XmlElement( ElementName = "BR_Procedure_Surgery_Loc_N"   )]
      public short gxTpr_Br_procedure_surgery_loc_N
      {
         get {
            return gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N = value;
            SetDirty("Br_procedure_surgery_loc_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name = "";
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc = "";
         gxTv_SdtBR_Procedure_Surgery_Mode = "";
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z = "";
         gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_procedure_surgery", "GeneXus.Programs.br_procedure_surgery_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Procedure_Surgery_Initialized ;
      private short gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_N ;
      private short gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_N ;
      private long gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid ;
      private long gxTv_SdtBR_Procedure_Surgery_Br_procedureid ;
      private long gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgeryid_Z ;
      private long gxTv_SdtBR_Procedure_Surgery_Br_procedureid_Z ;
      private String gxTv_SdtBR_Procedure_Surgery_Mode ;
      private String gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name ;
      private String gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc ;
      private String gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_name_Z ;
      private String gxTv_SdtBR_Procedure_Surgery_Br_procedure_surgery_loc_Z ;
   }

   [DataContract(Name = @"BR_Procedure_Surgery", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Procedure_Surgery_RESTInterface : GxGenericCollectionItem<SdtBR_Procedure_Surgery>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure_Surgery_RESTInterface( ) : base()
      {
      }

      public SdtBR_Procedure_Surgery_RESTInterface( SdtBR_Procedure_Surgery psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Procedure_SurgeryID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_surgeryid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_procedure_surgeryid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_procedure_surgeryid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_ProcedureID" , Order = 1 )]
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

      [DataMember( Name = "BR_Procedure_Surgery_Name" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_surgery_name
      {
         get {
            return sdt.gxTpr_Br_procedure_surgery_name ;
         }

         set {
            sdt.gxTpr_Br_procedure_surgery_name = value;
         }

      }

      [DataMember( Name = "BR_Procedure_Surgery_Loc" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_surgery_loc
      {
         get {
            return sdt.gxTpr_Br_procedure_surgery_loc ;
         }

         set {
            sdt.gxTpr_Br_procedure_surgery_loc = value;
         }

      }

      public SdtBR_Procedure_Surgery sdt
      {
         get {
            return (SdtBR_Procedure_Surgery)Sdt ;
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
            sdt = new SdtBR_Procedure_Surgery() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
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
