export interface NavItem {
  title: string;
  url: string;
  icon: string;
}

export const NAV_ITEMS: NavItem[] = [
  {
    title: 'Home',
    url: '/',
    icon: 'lucideHouse'
  },
  {
    title: 'Backlog',
    url: '#',
    icon: 'lucideBookMarked'
  },
  {
    title: 'Reviews',
    url: '#',
    icon: 'lucideCircleStar'
  }
];