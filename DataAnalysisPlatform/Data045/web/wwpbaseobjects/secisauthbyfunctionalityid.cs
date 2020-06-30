/*
               File: WWPBaseObjects.SecIsAuthByFunctionalityId
        Description: Is Authorized By Functionality Id
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.82
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class secisauthbyfunctionalityid : GXProcedure
   {
      public secisauthbyfunctionalityid( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secisauthbyfunctionalityid( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SecFunctionalityId ,
                           out bool aP1_IsAuthorized )
      {
         this.AV13SecFunctionalityId = aP0_SecFunctionalityId;
         this.AV10IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV10IsAuthorized;
      }

      public bool executeUdp( long aP0_SecFunctionalityId )
      {
         this.AV13SecFunctionalityId = aP0_SecFunctionalityId;
         this.AV10IsAuthorized = false ;
         initialize();
         executePrivate();
         aP1_IsAuthorized=this.AV10IsAuthorized;
         return AV10IsAuthorized ;
      }

      public void executeSubmit( long aP0_SecFunctionalityId ,
                                 out bool aP1_IsAuthorized )
      {
         secisauthbyfunctionalityid objsecisauthbyfunctionalityid;
         objsecisauthbyfunctionalityid = new secisauthbyfunctionalityid();
         objsecisauthbyfunctionalityid.AV13SecFunctionalityId = aP0_SecFunctionalityId;
         objsecisauthbyfunctionalityid.AV10IsAuthorized = false ;
         objsecisauthbyfunctionalityid.context.SetSubmitInitialConfig(context);
         objsecisauthbyfunctionalityid.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecisauthbyfunctionalityid);
         aP1_IsAuthorized=this.AV10IsAuthorized;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secisauthbyfunctionalityid)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV10IsAuthorized = true;
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV13SecFunctionalityId ;
      private bool AV10IsAuthorized ;
      private bool aP1_IsAuthorized ;
   }

}
