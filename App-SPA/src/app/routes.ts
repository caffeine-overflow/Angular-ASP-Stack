import { Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { MemberListComponent } from "./members/member-list/member-list.component";
import { MessagesComponent } from "./messages/messages.component";
import { ListComponent } from "./list/list.component";
import { AuthGuard } from "./_guards/auth.guard";
import { MemberDetailComponent } from "./members/member-detail/member-detail.component";

export const appRoutes: Routes = [
  { path: "home", component: HomeComponent },
  { path: "members", component: MemberListComponent, canActivate: [AuthGuard] },
  {
    path: "members/:id",
    component: MemberDetailComponent,
    canActivate: [AuthGuard]
  },
  { path: "messages", component: MessagesComponent, canActivate: [AuthGuard] },
  { path: "lists", component: ListComponent, canActivate: [AuthGuard] },
  { path: "**", redirectTo: "home", pathMatch: "full" }
];
