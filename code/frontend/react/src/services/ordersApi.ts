import { CreateOrderRequest } from '../models/createOrderRequest';
import { Order } from '../models/order';
import { OrderSummary } from '../models/orderSummary';
import { UpdateOrderStatusRequest } from '../models/updateOrderStatusRequest';

export async function getOrders(customerId?: string, status?: string): Promise<Order[]> {
  throw new Error('Not implemented');
}

export async function createOrder(request: CreateOrderRequest): Promise<Order> {
  throw new Error('Not implemented');
}

export async function updateOrderStatus(
  id: string,
  request: UpdateOrderStatusRequest
): Promise<Order> {
  throw new Error('Not implemented');
}

export async function getSummary(): Promise<OrderSummary> {
  throw new Error('Not implemented');
}