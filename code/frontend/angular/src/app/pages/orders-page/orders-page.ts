import { Component } from '@angular/core';
import { OrderForm } from '../../components/order-form/order-form';
import { OrderList } from '../../components/order-list/order-list';

@Component({
  selector: 'app-orders-page',
  imports: [OrderForm, OrderList],
  templateUrl: './orders-page.html',
  styleUrl: './orders-page.css',
})
export class OrdersPage {}
