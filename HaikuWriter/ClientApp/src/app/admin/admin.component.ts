import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UserService } from '../service/user.service';
import { User} from '../models/user.model'

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  constructor(private router: Router,
    private userService: UserService,) { }

  user = new User(" ", " ", " ", " ", " ", " ", " ", false);
  adminStatus: any;
  ngOnInit(): void {
    const username = localStorage.getItem('User')
    this.adminStatus = localStorage.getItem("Admin");
    if(username == null){
      this.router.navigateByUrl('/login')
    }
    if(this.adminStatus == "false"){
      this.router.navigateByUrl('/landingpage')
    }
    else{
      this.getUser(username);
    }
  }

  getUser(username: string | null){
    this.userService.getUserByUserName(username)
      .subscribe(
        res => {
          this.user = res;
        },
        err => {
          console.log("server error")
        }
    );
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/login')
  }

}
