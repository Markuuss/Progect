using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Support.V4.Widget;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;

namespace Languages_Programming
{
    [Activity(Label = "Languages_Programming", MainLauncher = true, Theme = "@style/Theme.DesignDemo")]
    public class MainActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        NavigationView navigationView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            // Create ActionBarDrawerToggle button and add it to the toolbar  
            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();
            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            setupDrawerContent(navigationView); //Calling Function 
            void setupDrawerContent(NavigationView navigationView)
            {
                navigationView.NavigationItemSelected += (sender, e) =>
                {
                    e.MenuItem.SetChecked(true);
                    switch (e.MenuItem.ItemId)
                    {
                        case Resource.Id.nav_messages:
                            {


                                break;
                            }
                        case Resource.Id.nav_home:
                            {

                                break;
                            }
                        case Resource.Id.nav_settings:
                            {


                                break;
                            }

                        default: break;
                    }
                    drawerLayout.CloseDrawers();
                };
            }
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            navigationView.InflateMenu(Resource.Menu.bottombar_menu); //Navigation Drawer Layout Menu Creation
            return true;
        }
    }
}
    
