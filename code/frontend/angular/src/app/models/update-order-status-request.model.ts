import { OrderStatus } from './order.model';

export interface UpdateOrderStatusRequest {
  status: OrderStatus;
}