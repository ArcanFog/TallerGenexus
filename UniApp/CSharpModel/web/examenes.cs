/*
               File: Examenes
        Description: Stub for Examenes
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/22/2020 21:6:15.52
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
using System.Web.Services;
using System.Data;
using GeneXus.Data;
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
namespace GeneXus.Programs {
   public class examenes : GXProcedure
   {
      public examenes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public examenes( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_ExamenFecha )
      {
         this.AV2ExamenFecha = aP0_ExamenFecha;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_ExamenFecha )
      {
         examenes objexamenes;
         objexamenes = new examenes();
         objexamenes.AV2ExamenFecha = aP0_ExamenFecha;
         objexamenes.context.SetSubmitInitialConfig(context);
         objexamenes.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexamenes);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((examenes)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         args = new Object[] {(DateTime)AV2ExamenFecha} ;
         ClassLoader.Execute("aexamenes","GeneXus.Programs","aexamenes", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 1 ) )
         {
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private DateTime AV2ExamenFecha ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
   }

}
