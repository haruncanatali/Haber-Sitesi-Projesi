using HaberSitesi.Business.Abstract;
using HaberSitesi.Business.Concrete;
using HaberSitesi.DataAccess.Abstract;
using HaberSitesi.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEditorService>().To<EditorManager>().InTransientScope();
            Bind<IEditorDal>().To<EditorDal>().InTransientScope();

            Bind<IHaberService>().To<HaberManager>().InTransientScope();
            Bind<IHaberDal>().To<HaberDal>().InTransientScope();

            Bind<IKategoriService>().To<KategoriManager>().InTransientScope();
            Bind<IKategoriDal>().To<KategoriDal>().InTransientScope();

            Bind<IYazarService>().To<YazarManager>().InTransientScope();
            Bind<IYazarDal>().To<YazarDal>().InTransientScope();

            Bind<IYaziService>().To<YaziManager>().InTransientScope();
            Bind<IYaziDal>().To<YaziDal>().InTransientScope();

            Bind<IHesapService>().To<HesapManager>().InSingletonScope();
            Bind<IHesapDal>().To<HesapDal>().InSingletonScope();

            Bind<IHesapHareketleriService>().To<HesapHareketleriManager>().InSingletonScope();
            Bind<IHesapHareketleriDal>().To<HesapHareketleriDal>().InSingletonScope();

            Bind<IYorumService>().To<YorumManager>().InTransientScope();
            Bind<IYorumDal>().To<YorumDal>().InTransientScope();
        }
    }
}
