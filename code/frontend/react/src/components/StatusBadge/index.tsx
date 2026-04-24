type StatusBadgeProps = {
  status: 'Pending' | 'Confirmed' | 'Cancelled';
};

export function StatusBadge({ status }: StatusBadgeProps) {
  return <span>{status}</span>;
}