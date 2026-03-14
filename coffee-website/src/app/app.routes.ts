import { Routes } from '@angular/router';
import { HomePage } from './home/home-page/home-page';
import { MenuPage } from './menu/menu-page/menu-page';
import { RewardsPage } from './rewards/rewards-page/rewards-page';
import { GiftPage } from './gift/gift-page/gift-page';
import { StoreLocatorPage } from './store-locator/store-locator-page/store-locator-page';

export const HomePageRoute = {
  path: '',
  component: HomePage,
};

export const MenuPageRoute = {
  path: 'menu',
  component: MenuPage,
};

export const RewardsPageRoute = {
  path: 'rewards',
  component: RewardsPage,
};

export const GiftPageRoute = {
  path: 'gift',
  component: GiftPage,
};

export const StoreLocatorPageRoute = {
  path: 'store-locator',
  component: StoreLocatorPage,
};


// Redirect any other URLs that don’t match
// (also known as a "wildcard" redirect)
export const RedirectRoute = {
  path: '**',
  redirectTo: '/',
};

export const routes: Routes = [
  HomePageRoute,
  MenuPageRoute,
  RewardsPageRoute,
  GiftPageRoute,
  StoreLocatorPageRoute,
  RedirectRoute
];
