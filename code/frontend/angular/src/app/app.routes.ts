import { Routes } from '@angular/router';
import { HomePage } from './pages/home-page/home-page';
import { OrdersPage } from './pages/orders-page/orders-page';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomePage },
    { path: 'orders', component: OrdersPage }
];
