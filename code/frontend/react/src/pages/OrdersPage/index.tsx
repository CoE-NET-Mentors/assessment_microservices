import { OrderForm } from '../../components/OrderForm';
import { OrderList } from '../../components/OrderList';

export function OrdersPage() {
  return (
    <main>
      <h1>Orders</h1>
      <p>Assessment starter page.</p>
      <OrderForm />
      <OrderList />
    </main>
  );
}