/*
               File: wwpbaseobjects.type_SdtSecFunctionalityRole
        Description: 权限-角色表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:43.54
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
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SecFunctionalityRole" )]
   [XmlType(TypeName =  "SecFunctionalityRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecFunctionalityRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecFunctionalityRole( )
      {
      }

      public SdtSecFunctionalityRole( IGxContext context )
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

      public void Load( long AV1SecFunctionalityId ,
                        short AV4SecRoleId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV1SecFunctionalityId,(short)AV4SecRoleId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecFunctionalityId", typeof(long)}, new Object[]{"SecRoleId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecFunctionalityRole");
         metadata.Set("BT", "SecFunctionalityRole");
         metadata.Set("PK", "[ \"SecFunctionalityId\",\"SecRoleId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SecFunctionalityId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SecRoleId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Secfunctionalityid_Z");
         state.Add("gxTpr_Secfunctionalitydescription_Z");
         state.Add("gxTpr_Secroleid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole)(source);
         gxTv_SdtSecFunctionalityRole_Secfunctionalityid = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalityid ;
         gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription ;
         gxTv_SdtSecFunctionalityRole_Secroleid = sdt.gxTv_SdtSecFunctionalityRole_Secroleid ;
         gxTv_SdtSecFunctionalityRole_Mode = sdt.gxTv_SdtSecFunctionalityRole_Mode ;
         gxTv_SdtSecFunctionalityRole_Initialized = sdt.gxTv_SdtSecFunctionalityRole_Initialized ;
         gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z ;
         gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z ;
         gxTv_SdtSecFunctionalityRole_Secroleid_Z = sdt.gxTv_SdtSecFunctionalityRole_Secroleid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecFunctionalityId", gxTv_SdtSecFunctionalityRole_Secfunctionalityid, false);
         AddObjectProperty("SecFunctionalityDescription", gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription, false);
         AddObjectProperty("SecRoleId", gxTv_SdtSecFunctionalityRole_Secroleid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecFunctionalityRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecFunctionalityRole_Initialized, false);
            AddObjectProperty("SecFunctionalityId_Z", gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z, false);
            AddObjectProperty("SecFunctionalityDescription_Z", gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z, false);
            AddObjectProperty("SecRoleId_Z", gxTv_SdtSecFunctionalityRole_Secroleid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole sdt )
      {
         if ( sdt.IsDirty("SecFunctionalityId") )
         {
            gxTv_SdtSecFunctionalityRole_Secfunctionalityid = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalityid ;
         }
         if ( sdt.IsDirty("SecFunctionalityDescription") )
         {
            gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription = sdt.gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription ;
         }
         if ( sdt.IsDirty("SecRoleId") )
         {
            gxTv_SdtSecFunctionalityRole_Secroleid = sdt.gxTv_SdtSecFunctionalityRole_Secroleid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId" )]
      [  XmlElement( ElementName = "SecFunctionalityId"   )]
      public long gxTpr_Secfunctionalityid
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secfunctionalityid ;
         }

         set {
            if ( gxTv_SdtSecFunctionalityRole_Secfunctionalityid != value )
            {
               gxTv_SdtSecFunctionalityRole_Mode = "INS";
               this.gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z_SetNull( );
               this.gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z_SetNull( );
               this.gxTv_SdtSecFunctionalityRole_Secroleid_Z_SetNull( );
            }
            gxTv_SdtSecFunctionalityRole_Secfunctionalityid = value;
            SetDirty("Secfunctionalityid");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityDescription" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription"   )]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription = value;
            SetDirty("Secfunctionalitydescription");
         }

      }

      [  SoapElement( ElementName = "SecRoleId" )]
      [  XmlElement( ElementName = "SecRoleId"   )]
      public short gxTpr_Secroleid
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secroleid ;
         }

         set {
            if ( gxTv_SdtSecFunctionalityRole_Secroleid != value )
            {
               gxTv_SdtSecFunctionalityRole_Mode = "INS";
               this.gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z_SetNull( );
               this.gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z_SetNull( );
               this.gxTv_SdtSecFunctionalityRole_Secroleid_Z_SetNull( );
            }
            gxTv_SdtSecFunctionalityRole_Secroleid = value;
            SetDirty("Secroleid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Mode ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecFunctionalityRole_Mode_SetNull( )
      {
         gxTv_SdtSecFunctionalityRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionalityRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Initialized ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecFunctionalityRole_Initialized_SetNull( )
      {
         gxTv_SdtSecFunctionalityRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionalityRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityId_Z"   )]
      public long gxTpr_Secfunctionalityid_Z
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z = value;
            SetDirty("Secfunctionalityid_Z");
         }

      }

      public void gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z_SetNull( )
      {
         gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityDescription_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription_Z"   )]
      public String gxTpr_Secfunctionalitydescription_Z
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z = value;
            SetDirty("Secfunctionalitydescription_Z");
         }

      }

      public void gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z_SetNull( )
      {
         gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleId_Z" )]
      [  XmlElement( ElementName = "SecRoleId_Z"   )]
      public short gxTpr_Secroleid_Z
      {
         get {
            return gxTv_SdtSecFunctionalityRole_Secroleid_Z ;
         }

         set {
            gxTv_SdtSecFunctionalityRole_Secroleid_Z = value;
            SetDirty("Secroleid_Z");
         }

      }

      public void gxTv_SdtSecFunctionalityRole_Secroleid_Z_SetNull( )
      {
         gxTv_SdtSecFunctionalityRole_Secroleid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecFunctionalityRole_Secroleid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription = "";
         gxTv_SdtSecFunctionalityRole_Mode = "";
         gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secfunctionalityrole", "GeneXus.Programs.wwpbaseobjects.secfunctionalityrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecFunctionalityRole_Secroleid ;
      private short gxTv_SdtSecFunctionalityRole_Initialized ;
      private short gxTv_SdtSecFunctionalityRole_Secroleid_Z ;
      private long gxTv_SdtSecFunctionalityRole_Secfunctionalityid ;
      private long gxTv_SdtSecFunctionalityRole_Secfunctionalityid_Z ;
      private String gxTv_SdtSecFunctionalityRole_Mode ;
      private String gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription ;
      private String gxTv_SdtSecFunctionalityRole_Secfunctionalitydescription_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecFunctionalityRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSecFunctionalityRole_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecFunctionalityRole_RESTInterface( ) : base()
      {
      }

      public SdtSecFunctionalityRole_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecFunctionalityId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalityid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Secfunctionalityid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Secfunctionalityid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SecFunctionalityDescription" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return sdt.gxTpr_Secfunctionalitydescription ;
         }

         set {
            sdt.gxTpr_Secfunctionalitydescription = value;
         }

      }

      [DataMember( Name = "SecRoleId" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secroleid
      {
         get {
            return sdt.gxTpr_Secroleid ;
         }

         set {
            sdt.gxTpr_Secroleid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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
