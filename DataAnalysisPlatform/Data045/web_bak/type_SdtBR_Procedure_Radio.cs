/*
               File: type_SdtBR_Procedure_Radio
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:34.98
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
   [XmlRoot(ElementName = "BR_Procedure_Radio" )]
   [XmlType(TypeName =  "BR_Procedure_Radio" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Procedure_Radio : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure_Radio( )
      {
      }

      public SdtBR_Procedure_Radio( IGxContext context )
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

      public void Load( long AV323BR_Procedure_RadioID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV323BR_Procedure_RadioID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Procedure_RadioID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Procedure_Radio");
         metadata.Set("BT", "BR_Procedure_Radio");
         metadata.Set("PK", "[ \"BR_Procedure_RadioID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Procedure_RadioID\" ]");
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
         state.Add("gxTpr_Br_procedure_radioid_Z");
         state.Add("gxTpr_Br_procedureid_Z");
         state.Add("gxTpr_Br_procedure_radio_loc_Z");
         state.Add("gxTpr_Br_procedure_radio_amount_Z");
         state.Add("gxTpr_Br_procedure_radio_loc_N");
         state.Add("gxTpr_Br_procedure_radio_amount_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Procedure_Radio sdt ;
         sdt = (SdtBR_Procedure_Radio)(source);
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid ;
         gxTv_SdtBR_Procedure_Radio_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedureid ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount ;
         gxTv_SdtBR_Procedure_Radio_Mode = sdt.gxTv_SdtBR_Procedure_Radio_Mode ;
         gxTv_SdtBR_Procedure_Radio_Initialized = sdt.gxTv_SdtBR_Procedure_Radio_Initialized ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z ;
         gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N ;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid), 18, 0)), false);
         AddObjectProperty("BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Radio_Br_procedureid), 18, 0)), false);
         AddObjectProperty("BR_Procedure_Radio_Loc", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc, false);
         AddObjectProperty("BR_Procedure_Radio_Loc_N", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N, false);
         AddObjectProperty("BR_Procedure_Radio_Amount", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount, false);
         AddObjectProperty("BR_Procedure_Radio_Amount_N", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Procedure_Radio_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Procedure_Radio_Initialized, false);
            AddObjectProperty("BR_Procedure_RadioID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z), 18, 0)), false);
            AddObjectProperty("BR_ProcedureID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z), 18, 0)), false);
            AddObjectProperty("BR_Procedure_Radio_Loc_Z", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z, false);
            AddObjectProperty("BR_Procedure_Radio_Amount_Z", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z, false);
            AddObjectProperty("BR_Procedure_Radio_Loc_N", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N, false);
            AddObjectProperty("BR_Procedure_Radio_Amount_N", gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Procedure_Radio sdt )
      {
         if ( sdt.IsDirty("BR_Procedure_RadioID") )
         {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid ;
         }
         if ( sdt.IsDirty("BR_ProcedureID") )
         {
            gxTv_SdtBR_Procedure_Radio_Br_procedureid = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedureid ;
         }
         if ( sdt.IsDirty("BR_Procedure_Radio_Loc") )
         {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc ;
         }
         if ( sdt.IsDirty("BR_Procedure_Radio_Amount") )
         {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount = sdt.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioID" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioID"   )]
      public long gxTpr_Br_procedure_radioid
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid ;
         }

         set {
            if ( gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid != value )
            {
               gxTv_SdtBR_Procedure_Radio_Mode = "INS";
               this.gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z_SetNull( );
               this.gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z_SetNull( );
            }
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid = value;
            SetDirty("Br_procedure_radioid");
         }

      }

      [  SoapElement( ElementName = "BR_ProcedureID" )]
      [  XmlElement( ElementName = "BR_ProcedureID"   )]
      public long gxTpr_Br_procedureid
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedureid ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedureid = value;
            SetDirty("Br_procedureid");
         }

      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Loc" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Loc"   )]
      public String gxTpr_Br_procedure_radio_loc
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N = 0;
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc = value;
            SetDirty("Br_procedure_radio_loc");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N = 1;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Amount" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Amount"   )]
      public String gxTpr_Br_procedure_radio_amount
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N = 0;
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount = value;
            SetDirty("Br_procedure_radio_amount");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N = 1;
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Mode ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Mode_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Initialized ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Initialized_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_RadioID_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_RadioID_Z"   )]
      public long gxTpr_Br_procedure_radioid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z = value;
            SetDirty("Br_procedure_radioid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_ProcedureID_Z" )]
      [  XmlElement( ElementName = "BR_ProcedureID_Z"   )]
      public long gxTpr_Br_procedureid_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z = value;
            SetDirty("Br_procedureid_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Loc_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Loc_Z"   )]
      public String gxTpr_Br_procedure_radio_loc_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z = value;
            SetDirty("Br_procedure_radio_loc_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Amount_Z" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Amount_Z"   )]
      public String gxTpr_Br_procedure_radio_amount_Z
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z = value;
            SetDirty("Br_procedure_radio_amount_Z");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Loc_N" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Loc_N"   )]
      public short gxTpr_Br_procedure_radio_loc_N
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N = value;
            SetDirty("Br_procedure_radio_loc_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Procedure_Radio_Amount_N" )]
      [  XmlElement( ElementName = "BR_Procedure_Radio_Amount_N"   )]
      public short gxTpr_Br_procedure_radio_amount_N
      {
         get {
            return gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N ;
         }

         set {
            gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N = value;
            SetDirty("Br_procedure_radio_amount_N");
         }

      }

      public void gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N_SetNull( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc = "";
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount = "";
         gxTv_SdtBR_Procedure_Radio_Mode = "";
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z = "";
         gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_procedure_radio", "GeneXus.Programs.br_procedure_radio_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Procedure_Radio_Initialized ;
      private short gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_N ;
      private short gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_N ;
      private long gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid ;
      private long gxTv_SdtBR_Procedure_Radio_Br_procedureid ;
      private long gxTv_SdtBR_Procedure_Radio_Br_procedure_radioid_Z ;
      private long gxTv_SdtBR_Procedure_Radio_Br_procedureid_Z ;
      private String gxTv_SdtBR_Procedure_Radio_Mode ;
      private String gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc ;
      private String gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount ;
      private String gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_loc_Z ;
      private String gxTv_SdtBR_Procedure_Radio_Br_procedure_radio_amount_Z ;
   }

   [DataContract(Name = @"BR_Procedure_Radio", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Procedure_Radio_RESTInterface : GxGenericCollectionItem<SdtBR_Procedure_Radio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Procedure_Radio_RESTInterface( ) : base()
      {
      }

      public SdtBR_Procedure_Radio_RESTInterface( SdtBR_Procedure_Radio psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Procedure_RadioID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_radioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_procedure_radioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_procedure_radioid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Procedure_Radio_Loc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_radio_loc
      {
         get {
            return sdt.gxTpr_Br_procedure_radio_loc ;
         }

         set {
            sdt.gxTpr_Br_procedure_radio_loc = value;
         }

      }

      [DataMember( Name = "BR_Procedure_Radio_Amount" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_procedure_radio_amount
      {
         get {
            return sdt.gxTpr_Br_procedure_radio_amount ;
         }

         set {
            sdt.gxTpr_Br_procedure_radio_amount = value;
         }

      }

      public SdtBR_Procedure_Radio sdt
      {
         get {
            return (SdtBR_Procedure_Radio)Sdt ;
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
            sdt = new SdtBR_Procedure_Radio() ;
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
