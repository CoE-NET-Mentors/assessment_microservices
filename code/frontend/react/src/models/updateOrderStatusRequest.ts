import { OrderStatus } from './order';

export interface UpdateOrderStatusRequest {
  status: OrderStatus;
}