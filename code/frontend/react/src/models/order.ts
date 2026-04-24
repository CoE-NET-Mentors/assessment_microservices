export type OrderStatus = 'Pending' | 'Confirmed' | 'Cancelled';

export interface Order {
  id: string;
  customerId: string;
  productId: string;
  quantity: number;
  status: OrderStatus;
  createdAt: string;
}