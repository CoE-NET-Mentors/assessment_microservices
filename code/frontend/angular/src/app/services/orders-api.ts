import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { CreateOrderRequest } from '../models/create-order-request.model';
import { Order } from '../models/order.model';
import { OrderSummary } from '../models/order-summary.model';
import { UpdateOrderStatusRequest } from '../models/update-order-status-request.model';

@Injectable({
  providedIn: 'root'
})
export class OrdersApi {
  getOrders(customerId?: string, status?: string): Observable<Order[]> {
    return throwError(() => new Error('Not implemented'));
  }

  createOrder(request: CreateOrderRequest): Observable<Order> {
    return throwError(() => new Error('Not implemented'));
  }

  updateOrderStatus(id: string, request: UpdateOrderStatusRequest): Observable<Order> {
    return throwError(() => new Error('Not implemented'));
  }

  getSummary(): Observable<OrderSummary> {
    return throwError(() => new Error('Not implemented'));
  }
}