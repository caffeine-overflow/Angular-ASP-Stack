// tslint:disable-next-line: quotemark
import { Photo } from "./photo";
export interface User {
  id: number;
  username: string;
  age: number;
  gender: string;
  created: Date;
  lastactive: Date;
  photourl: string;
  city: string;
  country: string;
  interests?: string;
  introduction?: string;
  lookingfor?: string;
  photos?: Photo[];
}
