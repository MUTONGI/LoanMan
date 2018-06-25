<div class="container col-md-12">
  <h3>Client Details</h3>
  <div class="row col-md-12">
    <div class="col-sm-6"><%--lfet container--%>
      <div class="form-group has-feedback">
        <label>
            Surname
        </label>
        <input id="txtSurname" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
        <div class="form-group has-feedback">
        <label>
            Firstname
        </label>
        <input id="txtFirstname" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
        <div class="form-group has-feedback">
        <label>
            ID Number
        </label>
        <input id="txtIDNumber" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
        <div class="form-group has-feedback">
            <label>
                Date Of Birth
            </label>
            <input id="txtDateOfBirth" type="text" class="form-control input-sm new-input required" name="Start Date" />
        </div>
     <div class="form-group has-feedback">
        <label>
            Gender
        </label>
        <select id="ddlGender" class="form-control input-sm new-input required" name="Start Date">
            <option value="-1">-- Select Gender --</option>
            <option value="1">Female</option>
            <option value="2">Male</option>
        </select>
      </div>
        <div class="form-group has-feedback">
        <label>
            Mobile Number
        </label>
        <input id="txtMobileNumber" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
        <div class="form-group has-feedback">
            <label>
                Telephone Number
            </label>
            <input id="txtTelephoneNumber" type="text" class="form-control input-sm new-input required" name="Start Date" />
        </div>
        <div class="form-group has-feedback">
            <label>
                Email Address
            </label>
            <input id="txtEmail" type="text" class="form-control input-sm new-input required" name="Start Date" />
        </div>
    </div>
    <div class="col-sm-6"><%--right container--%>
      <div class="form-group has-feedback">
        <label>
            Street Address 1
        </label>
        <textarea id="txtStreetAddress1" class="form-control input-sm new-input required" name="Start Date" />
      </div>
      <div class="form-group has-feedback">
        <label>
            Street Address 2
        </label>
        <textarea id="txtStreetAddress2" class="form-control input-sm new-input required" name="Start Date" />
      </div>
      <div class="form-group has-feedback">
        <label>
            City
        </label>
        <input id="txtCity" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
      <div class="form-group has-feedback">
        <label>
            Company 
        </label>
        <input id="txtCompany" type="text" class="form-control input-sm new-input required" name="Start Date" />
      </div>
      <div class="form-group has-feedback">
        <label>
            Company Address
        </label>
        <textarea id="txtCompanyAddress" class="form-control input-sm new-input required" name="Start Date" />
      </div>

    </div>
  </div>
    
</div>
<div class="col-md-12 interact-buttons margin-bottom-10">
        <hr />
        <span class="">
            <a class="btn btn-default btn-sm margin-bottom-5" id="btnSave" href="#">
                Save
            </a>
        </span>
        <span class="">
            <a runat="server" class="btn btn-default btn-sm margin-bottom-5 next_step" id="btnCancel">
                Cancel
            </a>
        </span>
    </div>