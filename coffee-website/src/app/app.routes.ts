import { Routes } from '@angular/router';
import { HomePage } from './home/home-page/home-page';

export const HomePageRoute = {
  path: '',
  component: HomePage,
};

// Redirect any other URLs that don’t match
// (also known as a "wildcard" redirect)
export const RedirectRoute = {
  path: '**',
  redirectTo: '/',
};

export const routes: Routes = [
  HomePageRoute,
  RedirectRoute
];
