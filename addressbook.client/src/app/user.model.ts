export interface Result {
  fullName: {
    title: string;
    first: string;
    last: string;
  };
  phone: string;
  email: string;
  location: {
    city: string;
    state: string;
    country: string;
  };
  picture: {
    large: string;
    medium: string;
    thumbnail: string;
  };
}

