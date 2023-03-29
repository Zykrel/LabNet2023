import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-shipperscreate',
  templateUrl: './shipperscreate.component.html',
  styleUrls: ['./shipperscreate.component.css']
})
export class ShipperscreateComponent implements OnInit {
  submitted: boolean = false;
  shipperForm!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.shipperForm = this.formBuilder.group({
      companyName: ['', [Validators.minLength(5), Validators.maxLength(40), Validators.required]],
      phone: ['', [Validators.minLength(8), Validators.maxLength(24), Validators.required]]
    })
  }

  onSubmit(){
    this.submitted = true;
    if(this.shipperForm.invalid){
      console.log(this.shipperForm.controls)
      return;
    }
    console.log(this.shipperForm.value);
  }

  get validatorArray(){
    return this.shipperForm.controls
  }
}
