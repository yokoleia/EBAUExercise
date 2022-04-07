export default function renderCustomerReport(ApiData) {
        return (
                <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                                <tr>
                                        <th>Customer ID</th>
                                        <th>Number of Orders</th>
                                        <th>Cost of Orders</th>
                                </tr>
                        </thead>
                        <tbody>
                                {ApiData.customerReport.map(customerReport =>
                                        <tr key={customerReport.customerId}>
                                                <td>{customerReport.customerId}</td>
                                                <td>{customerReport.orderCount}</td>
                                                <td>${
                                                        Number(customerReport.orderTotal).toFixed(2)
                                                }</td>
                                        </tr>
                                )}
                        </tbody>
                </table>
        );
}